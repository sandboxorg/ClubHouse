using ClubHouse.Models;
using System;
using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class EpicTests
    {

        [Fact]
        public async Task GetEpic()
        {
            var client = CreateClient();

            var foo = await client.Epics.Get(10);

            Assert.Equal(10, foo.Id);
            Assert.Equal(EpicState.InProgress, foo.State);
        }

        [Fact]
        public async Task UpdateEpic()
        {
            var client = CreateClient();

            var e = new Epic
            {
                Id = 10,
                Name = "new epic name",
                State = EpicState.InProgress
            };

            await client.Epics.Update(e);
        }

        [Fact]
        public async Task ListEpics()
        {
            var client = CreateClient();

            var foo = await client.Epics.List();

            Assert.Equal(4, foo.Count);
        }

        [Fact]
        public async Task CreateEpic()
        {
            var client = CreateClient();

            var foo = await client.Epics.Create(new Epic
            {
                Name = "Wasahhh"
            });

            Assert.Equal("Wasahhh", foo.Name);
        }

        [Fact]
        public async Task DeleteEpic()
        {
            var client = CreateClient();
            await client.Epics.Delete(10);
        }


        [Fact]
        public async Task UpdateEpicSettingBeforeId()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async Task UpdateEpicSettingAfterId()
        {
            throw new NotImplementedException();
        }
    }
}
