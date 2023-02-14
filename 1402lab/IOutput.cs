using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1402lab
{
    /* Создайте интерфейс IOutput.В нём должно быть два
метода:
■ void Show() — отображает информацию;
■ void Show(string info) — отображает информацию и
информационное сообщение, которое было указано
в параметре info.
Создайте класс Array (массив целого типа) с необхо-
димыми методами.Этот класс должен имплементировать
интерфейс IOutput.
Метод Show() — отображает на экран элементы массива.
Метод Show(string info) — отображает на экран эле-
менты массива и информационное сообщение, указанное
в параметре info.
Напишите код для тестирования полученной функ-
циональности.*/
    interface IOutput
    {
        void Show();
        void Show(string info);
        string Info { get; set; }
    }
}
