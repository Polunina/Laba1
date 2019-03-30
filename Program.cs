using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp
{
    class NoteBook
    {
        public static int id = 1;
        public static Dictionary<int, Note> noteBookList = new Dictionary<int, Note>();
        public static Note note2 = new Note();

        static void Main(string[] args)
        {
            Communication();
        }
        public static void CrateNewNote()
        {
            Console.WriteLine("Хотите создать новую запись?");
            string otv = Console.ReadLine();

            while (Equals(otv, "да"))
            {
                Console.WriteLine("Для создания новой записи заполните соответствующие поля");

                Note note1 = new Note();

                Console.WriteLine("Введите фамилию");
                note1.Surname = Console.ReadLine();
                Console.WriteLine("Введите имя");
                note1.Name = Console.ReadLine();
                Console.WriteLine("Хотите добавить отчество");
                string answerOtch = Console.ReadLine();
                if (Equals(answerOtch, "да"))
                {
                    Console.WriteLine("Введите отчество");
                    note1.Patronymic = Console.ReadLine();
                }
                try
                {
                    Console.WriteLine("Введите номер телефона");
                    note1.Number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Введите страну");
                note1.Country = Console.ReadLine();
                Console.WriteLine("Хотите добввить дату рождения?");
                string answerDate = Console.ReadLine();
                if (Equals(answerDate, "да"))
                {
                    Console.WriteLine("Введите дату");
                    note1.Date = Console.ReadLine();
                }
                Console.WriteLine("Хотите добавить предприятие?");
                string answerWork = Console.ReadLine();
                if (Equals(answerWork, "да"))
                {
                    Console.WriteLine("Введите название");
                    note1.Work = Console.ReadLine();
                }
                Console.WriteLine("Хотите добавить должность?");
                string answerPos = Console.ReadLine();
                if (Equals(answerPos, "да"))
                {
                    Console.WriteLine("Введите должность");
                    note1.Position = Console.ReadLine();
                }
                Console.WriteLine("Хотите добавить заметки?");
                string answerOther = Console.ReadLine();
                if (Equals(answerOther, "да"))
                {
                    Console.WriteLine("Добавьте Ваши заметки сюда");
                    note1.Other = Console.ReadLine();
                }
                Console.WriteLine("Запись добавлена");
                noteBookList.Add(id, note1);
                id++;
                Console.WriteLine("Хотите создать новую запись?");
                otv = Console.ReadLine();
            }
            Communication();
        }

        public static void EditNote()
        {
            Console.WriteLine("Запись под каким номером Вы хотите изменить?");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите фамилию");
            note2.Surname = Console.ReadLine();
            Console.WriteLine("Введите имя");
            note2.Name = Console.ReadLine();
            Console.WriteLine("Хотите добавить отчество");
            string answerOtch = Console.ReadLine();
            if (Equals(answerOtch, "да"))
            {
                Console.WriteLine("Введите отчество");
                note2.Patronymic = Console.ReadLine();
            }
            try
            {
                Console.WriteLine("Введите номер телефона");
                note2.Number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Введите страну");
            note2.Country = Console.ReadLine();
            Console.WriteLine("Хотите добввить дату рождения?");
            string answerDate = Console.ReadLine();
            if (Equals(answerDate, "да"))
            {
                Console.WriteLine("Введите дату");
                note2.Date = Console.ReadLine();
            }
            Console.WriteLine("Хотите добавить предприятие?");
            string answerWork = Console.ReadLine();
            if (Equals(answerWork, "да"))
            {
                Console.WriteLine("Введите название");
                note2.Work = Console.ReadLine();
            }
            Console.WriteLine("Хотите добавить должность?");
            string answerPos = Console.ReadLine();
            if (Equals(answerPos, "да"))
            {
                Console.WriteLine("Введите должность");
                note2.Position = Console.ReadLine();
            }
            Console.WriteLine("Хотите добавить заметки?");
            string answerOther = Console.ReadLine();
            if (Equals(answerOther, "да"))
            {
                Console.WriteLine("Добавьте Ваши заметки сюда");
                note2.Other = Console.ReadLine();
            }
            noteBookList[answer3] = note2;
            Console.WriteLine("Запись изменена");
            Communication();
        }
        public static void DeleteNote()
        {
            // ShowAllNote();
            Console.WriteLine("Запись под каким номером Вы желаете удалить?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            noteBookList.Remove(answer2);
            Console.WriteLine("Запись удалена");
            Console.ReadKey();
            Communication();
        }
        public static void ReadNote()
        {
            Console.WriteLine(noteBookList.Last());
            Communication();
        }
        public static void ShowAllNote()
        {
            foreach (KeyValuePair<int, Note> box in noteBookList)
            {
                Console.WriteLine(box.Key + " - " + box.Value);

            }
            Communication();
        }
        public static void Communication()
        {
            Console.WriteLine("Хотите начать работу?");
            string answer = Console.ReadLine();

            while (true)
            {

                if (Equals(answer, "да"))
                {
                    Console.Clear();
                    Console.WriteLine("Для создания новой записи нажмите 1" + '\n' +
                        "Для редактирования нажмите 2" + '\n' +
                        "Для удаления записи нажмите 3" + '\n' +
                        "Для просмотра последней записи нажмите 4" + '\n' +
                        "Для просмотра всех созданных записей нажмите 5");

                    string answer1 = Console.ReadLine();
                    switch (answer1)
                    {
                        case "1": CrateNewNote(); break;
                        case "2": EditNote(); break;
                        case "3": DeleteNote(); break;
                        case "4": ReadNote(); break;
                        case "5": ShowAllNote(); break;
                        default: Console.WriteLine("Повторите, что вы сказали?"); break;
                    }

                    break;
                }
                else
                    if (Equals(answer, "нет"))
                {
                    Console.Clear();
                    Console.WriteLine("Очень жаль! До встречи");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите что вы сказали");
                    answer = Console.ReadLine();
                }
                break;
            }
            Console.ReadKey();

        }

    }
}
