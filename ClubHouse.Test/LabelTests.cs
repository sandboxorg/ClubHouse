﻿using Xunit;
using static ClubHouse.Test.TestHelpers;


namespace ClubHouse.Test
{
    public class LabelTests
    {
        [Fact]
        public async System.Threading.Tasks.Task List()
        {
            var client = CreateClient();

            var result = await client.Labels.List();

            Assert.Equal(2, result.Count);

        }

        [Fact]
        public async System.Threading.Tasks.Task Create()
        {
            var client = CreateClient();

            var label = await client.Labels.Create(new Models.Label
            {
                Name = "This is my test label #2"
            });

            Assert.Equal(0, label.Statistics.StoriesCompleted);
        }

        [Fact]
        public async System.Threading.Tasks.Task Update()
        {
            var client = CreateClient();

            var label = await client.Labels.Update(new Models.Label
            {
                Id = 24,
                Name = "Updated via api, new!"
            });

            Assert.Equal(24, label.Id);
        }
    }
}
