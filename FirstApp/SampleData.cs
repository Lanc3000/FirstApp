using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApp.Models;

namespace FirstApp
{
    public static class SampleData
    {
        public static void Initialize(PersonaContext context) {
            if (!context.Personas.Any()) {
                context.Personas.AddRange(
                        new Persona
                        {
                            FirstName = "Василий",
                            LastName = "Сорокин",
                            FatherName = "Иванович",
                            Phone = 89271112233,
                            Sex = "Мужской",
                            Country = "Россия"
                        },
                        new Persona
                        {
                            FirstName = "Мария",
                            LastName = "Волкова",
                            FatherName = "Николаевна",
                            Phone = 89163332277,
                            Sex = "Женский",
                            Country = "Россия"
                        },
                        new Persona
                        {
                            FirstName = "Николай",
                            LastName = "Плюшко",
                            FatherName = "Михайлович",
                            Phone = 89659996655,
                            Sex = "Mужской",
                            Country = "Украйна"
                        }
                        );
                context.SaveChanges();
                   }

        }

    }
}
