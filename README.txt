Данный проект состоит из двух "подпроектов":
1) AdminPanel - панель администратора, написанная с помощью WindowsForms, через которую происходит добавление или удаление данных с сервера
2) Сам сервер, написанный на PHP, в некоторых местах встречается JavaScript. Частично использован Bootstrap

-Я планирую полностью изменить дизайн в AdminPanel, так как считаю неудобной работу с ним в его текущем состоянии, но пока используется старый дизайн

-В папке AdminPanel(source code) можно посмотреть исходный код и макет нового дизайна (основной функционал не работает, т.к. запускается с новой, недоделанной формы, если запускать с Form1, то всё будет работать)
-В папке GameObserver находится сам сервер, а в папке DB лежит база данных
-На данный момент сервер не может сам создать базу данных по указанному пути и поэтому, будет искать по пути на моём ПК (я сделал это для себя), в будущем реализую возможность добавления в папку, указанную в AdminPanel 

Что реализовано в данный момент:
1) Возможность добавлять/удалять игру на сайт через AdminPanel (так же можно добавлять/удалять жанры и связывать их с игрой)
 	При добавлении игры, AdminPanel создаёт её в базе данных, а потом "читает" все игры с базы данных через PHP
2) Возможность зарегестрироваться на сайте (пользователь сохраняется в базе данных, а так же в куках)
3) Возможность выбрать путь к серверу. По этой директории будет создана файловая система для хранения изображений (скриншотов и превью)

Известные ошибки:
1) Коментарии отображаются для всех игр, а не для одной
2) "Криво" работает предпросмотр скриншотов на странице с игрой
3) Изображения, загружаемые на сайт, плохо масштабированы
4) Front-End нуждается в доработке