# rx-template-appliedhttpclient
Репозиторий с шаблоном разработки «Прикладной HTTP клиент».

## Описание
Библиотека позоволяет отправлять HTTP запросы, используся методы Get, Post, Put, Delete. К каждому из методов запроса можно добавить аутентификацию, тело. 

Методы аутентификации: 
1. Basic
2. Bearer
3. Ntlm

Типы тела запроса:
1. Json
2. Xml
3. Загрузка файла 

## Состав объектов разработки:
1.	Решение BarCode, включающее асинхронный обработчик по вставке штрихкодов и конвертации в pdf. 
Поскольку решение BarCode  не содержит перекрытий объектов коробочного решения, конфликты при публикации не возникнут. Это позволяет использовать функциональность, как при старте нового проекта, так и в ходе сопровождения существующих инсталляций системы. 
2.	Решение BarCodeTemplate, включающее вызов вставки штрихкода по действию на ленте в карточке Договора.  Служит в качестве примера вызова асинхронного обработчика, не предназначено для публикации в рамках проектов.

## Варианты расширения функциональности на проектах
1. Создание своего HTTP клиента под разные нужды
2. Добавление метода аутентфикации
3. Добавление методов загрузки файла 

## Порядок установки
Для работы требуется установленный Directum RX версии 4.0 и выше

## Установка для ознакомления
1. Склонировать репозиторий с rx-template-appliedhttpclient в папку

## Установка для использования на проекте
Возможные варианты

### A. Fork репозитория.
1. Сделать fork репозитория rx-template-appliedhttpclient для своей учетной записи
2. Склонировать созданный в п. 1 репозиторий в папку
3. Подлючить библиотеку в прикладной проект

### B. Подключение на базовый слой.
Вариант не рекомендуется, так как при выходе версии шаблона разработки не гарантируется обратная совместимость.
1. Склонировать репозиторий rx-template-barcodehandler в папку.
2. Склонировать созданный в п. 1 репозиторий в папку
3. Подлючить библиотеку в прикладной проект

### C. Копирование репозитория в систему контроля версий.
Рекомендуемый вариант для проектов внедрения.
1. В системе контроля версий с поддержкой git создать новый репозиторий.
2. Склонировать репозиторий rx-template-appliedhttpclient в папку с ключом --mirror.
3. Перейти в папку из п. 2.
4. Импортировать клонированный репозиторий в систему контроля версий командой:
git push –mirror <Адрес репозитория из п. 1>