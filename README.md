## **Описание решения**

1. Программа просит ввести значения разной длины через пробел. Происходит запись значений в переменную с типом строка.
2. В строке выделяются элементы и записываются в массив строк.
3. Полученный массив через метод *string StringLessThree(string[] arr)* преобразуется в  **строку**, где элементы подвергаются отбору. Если длина элемента  3 и менее символов, то он записывается в строку в первоначальном виде. Иначе - замещается на пустой элемент.
4. Полученная строка преобразовывается в результирующий массив, при этом пустые элементы обрасываются.
Выводится полученный массив (с длиной элементов до 3-х символов) с использованием метода *void PrintArray(string[] array)*.
__________________________
Пустые строки добавлены для разделения результатов действий.

* ## Блок-схема

![Блок-схема](block%20scheme.jpg)






