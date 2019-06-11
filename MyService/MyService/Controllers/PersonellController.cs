using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyService.Models;

namespace MyService.Controllers
{
    public class PersonellController : ApiController
    {

        PersonnelModel[] PersonnelModels = new PersonnelModel[]
        {
            new PersonnelModel { Id = new Guid("e7d486af-ee6a-447d-86f0-a7ebd30fe296"), Name = "Quentin Tarantino", Email = "quentin@pulpfiction.tst", Phone = "555-555-5551" },
            new PersonnelModel { Id = new Guid("ffbd6846-b60d-480a-8b77-3b09b146c011"), Name = "Brad Pitt", Email = "bradp@fightclub.tst", Phone = "555-555-5551" },
            new PersonnelModel { Id = new Guid("5eafb6a5-bacc-458d-a010-bf8f810ce2fe"), Name = "Leonardo DiCaprio", Email = "leonardo.dicaprio@titanic.lcl", Phone = "555-555-5551" }
        };

        [HttpPost]
        public bool AddEmpDetails()
        {
            return true;
        }

        [HttpGet]
        public PersonnelModel[] GetAllPersonnel()
        {
            return PersonnelModels;
        }

        [HttpGet]
        public PersonnelModel GetPersonnelById(Guid id)
        {
            var result = PersonnelModels.FirstOrDefault(p => p.Id.Equals(id));
            return result;
        }

        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;
        }

        [HttpPut]
        public string UpdateEmpDetails(PersonnelModel model)
        {
            return "Employee details Updated with Name " + model.Name + " and Id " + model.Id;

        }
    }
}
