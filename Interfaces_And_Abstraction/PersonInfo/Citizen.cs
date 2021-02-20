﻿using System;
namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Citizen(string name, int age, string id) : this(name, age)
        {
            this.Id = id;
        }
        public Citizen(string name, int age, string id, string birthdate) : this(name, age, id)
        {
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}

