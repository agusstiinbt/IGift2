﻿using System.Net.Http.Json;

namespace Shared
{
    public class Person
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
    }

    public interface IPersonService
    {
        Task<List<Person>> GetPeopleAsync();
    }

    public class PersonService : IPersonService
    {
        private readonly HttpClient _httpClient;

        public PersonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Person>> GetPeopleAsync()
        {
            var response = await _httpClient.GetAsync("api/Person/GetAll");

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return await response.Content.ReadFromJsonAsync<List<Person>>();
                }
                catch (Exception)
                {
                }
            }
            return new List<Person>();
        }
    }

    public class PersonServiceServer : IPersonService
    {
        public async Task<List<Person>> GetPeopleAsync()
        {
            var lista = new List<Person>()
            {
                new Person(){Nombre="Agustin",Apellido="Esposito" },
                new Person(){Nombre="Lucia",Apellido="Esposito" },
                new Person(){Nombre="Jose",Apellido="Esposito" },
            };
            return await Task.FromResult(lista);
        }
    }
}
