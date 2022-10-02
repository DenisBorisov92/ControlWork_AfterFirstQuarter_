**Задача:**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры , либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Блок схема**
Блок-схема представленна в файле Блок-схема к задаче.jpg
**Решение**
Создаем два метода, один метод будет отвечать за вывод массива в одну строчку, с заданными нами элементами( мы сами генирируем количество элементов и какие они будут)
Второй метод будет выводить(отображать массив) в одну строчку.
В третьем методе string мы создаем массив для отображения элементов c заданным условием: создаем массив и переменную count, в которую будем записывать значения удовлетворяющие условиям проверки, при помощи цикла for будем проходить по всем значениям массива, а условие проверки будет содержаться в if( количество символов меньше либо равно 3), после перебора всех элементов и добавления их в count цикл завершается, формируем новый массив, в котором будут содержаться все выбранные элементы. При помощи метода void вызовем новый массив с удовлетворяющими нас значениями в консоль.
