﻿using NSubstitute;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Pipedrive.Tests.Clients
{
    public class ActivityTypesClientTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnsuresNonNullArguments()
            {
                Assert.Throws<ArgumentNullException>(() => new ActivityTypesClient(null));
            }
        }

        public class TheGetAllMethod
        {
            [Fact]
            public async Task RequestsCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new ActivityTypesClient(connection);

                await client.GetAll();

                Received.InOrder(async () =>
                {
                    await connection.GetAll<ActivityType>(Arg.Is<Uri>(u => u.ToString() == "activityTypes"));
                });
            }
        }

        public class TheCreateMethod
        {
            [Fact]
            public void PostsToTheCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new ActivityTypesClient(connection);

                var newActivityType = new NewActivityType("name", ActivityTypeIcon.Bell);
                client.Create(newActivityType);

                connection.Received().Post<ActivityType>(Arg.Is<Uri>(u => u.ToString() == "activityTypes"),
                    Arg.Is<NewActivityType>(nc => nc.Name == "name"
                        && nc.IconKey == ActivityTypeIcon.Bell));
            }
        }

        public class TheEditMethod
        {
            [Fact]
            public void PutsCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new ActivityTypesClient(connection);

                var editActivity = new ActivityTypeUpdate { Name = "name", IconKey = ActivityTypeIcon.Linegraph };
                client.Edit(123, editActivity);

                connection.Received().Put<ActivityType>(Arg.Is<Uri>(u => u.ToString() == "activityTypes/123"),
                    Arg.Is<ActivityTypeUpdate>(nc => nc.Name == "name"
                        && nc.IconKey == ActivityTypeIcon.Linegraph));
            }
        }

        public class TheDeleteMethod
        {
            [Fact]
            public void DeletesCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new ActivitiesClient(connection);

                client.Delete(123);

                connection.Received().Delete(Arg.Is<Uri>(u => u.ToString() == "activities/123"));
            }
        }
    }
}