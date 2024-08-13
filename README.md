# rx-template-appliedhttpclient
Репозиторий с шаблоном разработки «Прикладной HTTP клиент».

## Описание
Для реализации интеграций со стороними системами на проектах часто требуется вызывать методы сторонних веб сервисов, например, при интеграции с SAP PO/PI.
В рамках шаблона разработки реализована библиотека для отправки сообщений в сторонние системы.

Библиотека позволяет отправлять HTTP запросы, для взаимодействия с веб сервисами построеными как по технологии REST API, так и использующими протокол SOAP.

Реализованы методы Get, Post, Put, Delete. 

Методы аутентификации: 
1. Basic
2. Bearer
3. Ntlm

Типы тела запроса:
1. Json
2. Xml
3. Загрузка файла

Для обработки результата запроса определено 2 метода:
1. OnSuccess – выполняется в случае успешного выполнения запроса. Данный метод в себе содержит структуру ответа из следующих свойств:
  o	StatusCode – статус код запроса;
  o	Headers – заголовки ответа;
  o	Response – ответ на запрос в виде потока.
2. OnFail - выполняется в случае ошибки при выполнении запроса.

Пример подключения библиотеки и вызовов методов см. в Инструкция по использованию.docx

## Варианты расширения функциональности на проектах
1. Создание своего HTTP клиента под разные нужды
2. Добавление метода аутентификации
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
1. Склонировать репозиторий rx-template-appliedhttpclient в папку.
2. Склонировать созданный в п. 1 репозиторий в папку
3. Подлючить библиотеку в прикладной проект

### C. Копирование репозитория в систему контроля версий.
Рекомендуемый вариант для проектов внедрения.
1. В системе контроля версий с поддержкой git создать новый репозиторий.
2. Склонировать репозиторий rx-template-appliedhttpclient в папку с ключом --mirror.
3. Перейти в папку из п. 2.
4. Импортировать клонированный репозиторий в систему контроля версий командой:
git push –mirror <Адрес репозитория из п. 1>
