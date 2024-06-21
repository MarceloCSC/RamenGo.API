﻿using RamenGo.API.Models;

namespace RamenGo.API.Repositories
{
    public class MockBrothRepository : IRepository<Broth>
    {
        private readonly List<Broth> _broths;

        public MockBrothRepository()
        {
            _broths = new List<Broth>()
            {
                new()
                {
                    Id = "1",
                    Name = "Salt",
                    Description = "Simple like the seawater, nothing more.",
                    Price = "US$ 10",
                    ImageActive = "https://tech.redventures.com.br/icons/salt/active.svg",
                    ImageInactive = "https://tech.redventures.com.br/icons/salt/inactive.svg"
                },

                new()
                {
                    Id = "2",
                    Name = "Shoyu",
                    Description = "The good old and traditional soy sauce.",
                    Price = "US$ 10",
                    ImageActive = "https://tech.redventures.com.br/icons/shoyu/active.svg",
                    ImageInactive = "https://tech.redventures.com.br/icons/shoyu/inactive.svg"
                },

                new()
                {
                    Id = "3",
                    Name = "Miso",
                    Description = "Paste made of fermented soybeans.",
                    Price = "US$ 12",
                    ImageActive = "https://tech.redventures.com.br/icons/miso/active.svg",
                    ImageInactive = "https://tech.redventures.com.br/icons/miso/inactive.svg"
                }
            };
        }

        public async Task<List<Broth>> GetAllAsync()
        {
            return await Task.FromResult(_broths);
        }

        public async Task<Broth?> GetAsync(string id)
        {
            return await Task.FromResult(_broths.FirstOrDefault(broth => broth.Id == id));
        }

        public async Task AddAsync(Broth item)
        {
            await Task.FromException<NotImplementedException>(new NotImplementedException());
        }
    }
}