# Решение задачи

1. Пользователь с клавиатуры задает размерность массива *(N)*.
2. Создаем массив типа *String*.
3. С помощью метода **FillArray** даем пользователю возможность заполнить элементы массива.
4. С помощью метода **PrintArray** выводим на печать исходный массив.
5. Создаем переменную *i* типа Int, присваеваем её значение 0.
6. Прописываем цикл *While*, условием выхода из которого будет **i < N**.
7. Прописываем конструкцию *if*. (Если длина строки элемента массива с индексом i равна 3, то печатаем этот элемент массива).
8. Увеличиваем счетчик на 1, возвращаемся к циклу *While*.

## Методд **FillArray**

1. На вход подается массив типа *String*. На выход ничего не возвращается (void).
2. Создаем переменную *i* типа Int, присваеваем её значение 0.
3. Прописываем цикл *While*, условием выхода из которого будет **i < array.length** (i меньше размерности массива).
4. Пользователь вводит элемент массива.
5. Увеличиваем счетчик на 1, возвращаемся к циклу.

## Методд **PrintArray**

1. На вход подается массив типа *String*. На выход ничего не возвращается (void).
2. Создаем переменную *i* типа Int, присваеваем её значение 0.
3. Прописываем цикл *While*, условием выхода из которого будет **i < array.length** (i меньше размерности массива).
4. Выводим на печать элемент массива (*Write*).
5. Увеличиваем счетчик на 1, возвращаемся к циклу.

