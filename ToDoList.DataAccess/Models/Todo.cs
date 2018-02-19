using Newtonsoft.Json;
using System;

namespace ToDoList.DataAccess.Models
{
    public class Todo
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isCompleted")]
        public bool IsCompleted { get; set; }
    }
}
