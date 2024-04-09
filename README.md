## Как залить репозиторий на Github.com

1. Заходим на сайт github.com
2. В верхнем правом меню жмём на кнопку "Стрелка с плюсом" -> New repository 
3. Пишем название репозитория и жмём внизу кнопку "Create repository"
4. Создаём папку на рабочем столе и открываем её в VSCode
5. Открываем терминал через View -> Terminal
6. Инициализируем гит: в терминале пишем `git init`. Создаётся папка .git в рабочей папке
7. В терминале пишем команду `echo "# gb-kontrolnaya_1" >> README.md`. Создаётся файл README.md
8. Добавляем файл README.md в отслеживаемый: `git add README.md`. Проверяем добавление: `git status`
9. Создаём первый коммит командой в терминале: `git commit -m "first commit"`
10. Переименуем главную ветку в main: `git branch -M main`
11. Проверим переименование: `git branch`
12. Создадим соединение: `git remote add origin https://github.com/AndrIrkutsk/gb-kontrolnaya_1.git`
13. Запушим на Гитхаб: `git push -u origin main`


## Создание блок-схемы

> Условие:
>
> Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

> Примеры:
```sh
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
### Решение

1. Создаём эллипс со значением start (https://drive.google.com/file/d/1-9e4WPlcAtPSLPeuHFNhxckxQ3ByvNnk/view?usp=sharing)
2. Создаём параллелограм для ввода пользователем массива (https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&title=scheme-kontrolnaya.drawio#Uhttps%3A%2F%2Fdrive.google.com%2Fuc%3Fid%3D1-9e4WPlcAtPSLPeuHFNhxckxQ3ByvNnk%26export%3Ddownload)
3. Инициализация переменных и создание цикла (https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&title=scheme-kontrolnaya.drawio#Uhttps%3A%2F%2Fdrive.google.com%2Fuc%3Fid%3D1-9e4WPlcAtPSLPeuHFNhxckxQ3ByvNnk%26export%3Ddownload)
4. Создание тела цикла (https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&title=scheme-kontrolnaya.drawio#Uhttps%3A%2F%2Fdrive.google.com%2Fuc%3Fid%3D1-9e4WPlcAtPSLPeuHFNhxckxQ3ByvNnk%26export%3Ddownload)
5. Вносим правки и дописываем вывод (https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&title=scheme-kontrolnaya.drawio#Uhttps%3A%2F%2Fdrive.google.com%2Fuc%3Fid%3D1-9e4WPlcAtPSLPeuHFNhxckxQ3ByvNnk%26export%3Ddownload)

