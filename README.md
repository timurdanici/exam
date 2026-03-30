# АвтоСервис — Windows Forms приложение

Приложение **Windows Forms (.NET Framework 4.7.2)** для автоматизации работы автосервиса.  
Позволяет хранить данные о **клиентах** и их **автомобилях**, выполнять операции CRUD, осуществлять поиск и просматривать отчёт.

---

## Функциональность

| Раздел | Возможности |
|---|---|
| **Клиенты** | Просмотр, добавление, редактирование, удаление клиентов |
| **Автомобили** | Просмотр, добавление, редактирование, удаление автомобилей; поиск по марке или гос. номеру |
| **Отчёт** | Список клиентов и принадлежащих им автомобилей (JOIN-запрос) |

---

## Структура базы данных

### Клиенты
| Поле | Тип | Описание |
|---|---|---|
| `ID_клиента` | INT IDENTITY | Первичный ключ |
| `Фамилия` | NVARCHAR(100) | Обязательное |
| `Имя` | NVARCHAR(100) | Обязательное |
| `Телефон` | NVARCHAR(20) | Необязательное |
| `Адрес` | NVARCHAR(255) | Необязательное |

### Автомобили
| Поле | Тип | Описание |
|---|---|---|
| `ID_автомобиля` | INT IDENTITY | Первичный ключ |
| `Марка` | NVARCHAR(100) | Обязательное |
| `Модель` | NVARCHAR(100) | Обязательное |
| `Год_выпуска` | INT | Обязательное, 1900–текущий год |
| `Гос_номер` | NVARCHAR(20) | Обязательное |
| `ID_клиента` | INT (FK) | Внешний ключ → Клиенты |

---

## Требования

- **ОС**: Windows 7 / 8 / 10 / 11
- **.NET Framework**: 4.7.2 или выше
- **SQL Server**: LocalDB (устанавливается вместе с Visual Studio) **или** SQL Server Express
- **Visual Studio**: 2019 / 2022 (рекомендуется)

---

## Установка и запуск

### 1. Клонировать репозиторий

```bash
git clone https://github.com/timurdanici/exam.git
cd exam
```

### 2. Создать базу данных

#### Вариант A — через SQL Server Management Studio (SSMS) или Azure Data Studio

1. Подключитесь к `(LocalDB)\MSSQLLocalDB` (или вашему SQL Server Express).
2. Откройте файл `database.sql` из корня репозитория.
3. Выполните скрипт (F5). Он создаст БД `AutoService` с таблицами и тестовыми данными.

#### Вариант B — через командную строку (sqlcmd)

```bash
sqlcmd -S "(LocalDB)\MSSQLLocalDB" -i database.sql
```

### 3. Настроить строку подключения (при необходимости)

Файл: `AutoService\AutoService\App.config`

```xml
<connectionStrings>
  <add name="AutoServiceDB"
       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AutoService;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Если вы используете SQL Server Express с именованным экземпляром, замените `(LocalDB)\MSSQLLocalDB` на, например, `.\SQLEXPRESS`.

### 4. Открыть и собрать проект

1. Откройте файл `AutoService\AutoService.sln` в Visual Studio.
2. Нажмите **Build → Build Solution** (Ctrl+Shift+B).
3. Запустите приложение (**F5** или **Debug → Start Debugging**).

---

## Структура проекта

```
AutoService/
├── AutoService.sln
└── AutoService/
    ├── App.config                  ← строка подключения к БД
    ├── Program.cs                  ← точка входа
    ├── Models/
    │   ├── Client.cs               ← модель «Клиент»
    │   └── Car.cs                  ← модель «Автомобиль»
    ├── Data/
    │   ├── DatabaseHelper.cs       ← вспомогательный класс (подключение)
    │   ├── ClientRepository.cs     ← CRUD для клиентов (ADO.NET)
    │   └── CarRepository.cs        ← CRUD для автомобилей + поиск + отчёт
    └── Forms/
        ├── MainForm.cs/.Designer.cs        ← главная форма (3 вкладки)
        ├── AddEditClientForm.cs/.Designer.cs ← диалог клиента
        └── AddEditCarForm.cs/.Designer.cs   ← диалог автомобиля (ComboBox клиента)
database.sql                        ← скрипт создания БД
```

---

## Технологии

- **.NET Framework 4.7.2** — платформа
- **Windows Forms** — пользовательский интерфейс
- **ADO.NET** (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) — доступ к данным
- **SQL Server LocalDB / Express** — база данных
