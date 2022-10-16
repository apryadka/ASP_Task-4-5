using System.Collections;
using System.Collections.Generic;
using Web.Domain;

namespace Web.Dao
{
    public class QuestionDao
    {
        public IEnumerable<Question> getAll 
        { 
            get
            {
                return new List<Question>()
                {
					
                    new Question("ASP net це?", new List<Answear>()
                    {
                        new Answear("Мова програмуваня",false),
                        new Answear("Хостинг",false),
                        new Answear("Java сервіс.",false),
                        new Answear("Технологія створення вебзастосунків і вебсервісів",true),
                    }),
					
                     new Question("Остання версія технології ASP.NET", new List<Answear>()
                    {
                        new Answear("6.0",true),
                        new Answear("3.0",false),
                        new Answear("2.1",false),
                        new Answear("5.0",false),
                    }),
					
                     new Question("На чому основана ASP.NET", new List<Answear>()
                    {
                        new Answear("На  HTTP",true),
                        new Answear("На Java",false),
                        new Answear("На  Linux",false),
                        new Answear("На магії",false),
                    }),
					
                     new Question("ASP.NET бере свою назву від", new List<Answear>()
                    {
                        new Answear("Назви компанії",false),
                        new Answear("Імені засеовника",false),
                        new Answear("Системних драйверів",false),
                        new Answear("Від старої технології Microsoft ASP",true),
                    }),
					
					new Question("Вартість користування платформою", new List<Answear>()
                    {
                        new Answear("Безкоштовне користування",true),
                        new Answear("Платне для усіх видів користувачів",false),
                        new Answear("Безкоштовний тріал",false),
                        new Answear("Розповсюджується по ліцензії Creative Common",false),
                    }),
					
					new Question("ASP.NET Core включає", new List<Answear>()
                    {
                        new Answear("фреймворк MVC",true),
                        new Answear("Maven ",false),
                        new Answear("VS Соde",false),
                        new Answear("бібліотеку Windows Api",false),
                    }),
					
					new Question("Перевага ASP.NET Core", new List<Answear>()
                    {
                        new Answear("Синтаксис",false),
                        new Answear("Платформа",false),
                        new Answear("Магія",false),
                        new Answear("швидкість та кросплатформа",true),
                    }),

                    new Question("мова платформи .NET ", new List<Answear>()
                    {
                        new Answear("C#",true),
                        new Answear("Java",false),
                        new Answear("Tcl",false),
                        new Answear("Pascal",false),
                    }),
					
					new Question("MVC це", new List<Answear>()
                    {
                        new Answear("Технологія розгобки",true),
                        new Answear("Бібліотека веб форм",false),
                        new Answear("Біла магія",false),
                        new Answear("Чорна магія",false),
                    }),
					
					new Question(".NET Framework це", new List<Answear>()
                    {
                        new Answear("Популярний хостинг зображень",false),
                        new Answear("Консольний редактор тексту",false),
                        new Answear("середовище виконання, призначене лише для Windows",true),
                        new Answear("Програма-шифрувач паролей",false),
                    })
                };
            }
        } 
    }
}
