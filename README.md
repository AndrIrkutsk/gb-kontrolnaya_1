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