using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1402lab
{
    /*Создайте интерфейс ISort.В нём должно быть два
метода
■ void SortAsc() — сортировка по возрастанию;
■ void SortDesc() — сортировка по убыванию;
■ void SortByParam(bool isAsc) — сортировка в зави-
симости от переданного параметра.Если isAsc равен
true, сортируем по возрастанию.Если isAsc равен false,
сортируем по убыванию.
Практическое задание
2
Класс, созданный в первом задании Array, должен
имплементировать интерфейс ISort.
Метод SortAsc — сортирует массив по возрастанию.
Метод SortDesc — сортирует массив по убыванию.
Метод SortByParam — сортирует массив в зависимости
от переданного параметра.Если isAsc равен true, сорти-
руем по возрастанию.Если isAsc равен false, сортируем
по убыванию.
Напишите код для тестирования полученной функ-
циональности.*/
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
