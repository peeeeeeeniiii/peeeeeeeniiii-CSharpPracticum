
## Task 01 --- Создание базы и таблиц

### Запрос

База данных и четыре таблицы создаются скриптом `init.sql`. Для проверки
существования таблиц выполни:

``` sql
USE PracticeDB;
GO

SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;
```

Проверка внешних ключей:

``` sql
SELECT
    name AS ForeignKeyName,
    OBJECT_NAME(parent_object_id) AS TableName
FROM sys.foreign_keys
ORDER BY TableName, ForeignKeyName;
```

### Результат

Ожидаются четыре таблицы:

-   `Departments`
-   `Employees`
-   `Projects`
-   `EmployeeProjects`

Также должны присутствовать внешние ключи между таблицами. У `Employees`
есть внешний ключ `ManagerId`, ссылающийся на `Employees.EmployeeId`.

**Фактический результат:** заполнить после выполнения запросов в SSMS.

### Вывод

База `PracticeDB` и таблицы создаются скриптом `init.sql`. Первичные
ключи уникально определяют записи, а внешние ключи связывают таблицы и
помогают сохранять целостность данных.

------------------------------------------------------------------------

## Task 02 --- INSERT: заполнение данными

### Запрос

Тестовые данные добавляются командами `INSERT INTO ... VALUES` из файла
`init.sql`.

Проверка количества записей:

``` sql
SELECT COUNT(*) AS DepartmentCount FROM Departments;
SELECT COUNT(*) AS EmployeeCount FROM Employees;
SELECT COUNT(*) AS ProjectCount FROM Projects;
SELECT COUNT(*) AS EmployeeProjectCount FROM EmployeeProjects;
```

### Результат

Ожидаемое количество строк:

  Таблица                Количество
  -------------------- ------------
  `Departments`                   4
  `Employees`                    10
  `Projects`                      5
  `EmployeeProjects`             14

**Фактический результат:** заполнить после выполнения запросов в SSMS.

### Вывод

Данные добавлены в четыре таблицы. `COUNT(*)` позволяет проверить
количество записей в каждой таблице.

------------------------------------------------------------------------

## Task 03 --- SELECT + WHERE: базовые выборки

### Запрос

**1. Сотрудники с зарплатой больше 50000**

``` sql
SELECT *
FROM Employees
WHERE Salary > 50000;
```

**2. Сотрудники, нанятые в 2023 году**

``` sql
SELECT *
FROM Employees
WHERE YEAR(HireDate) = 2023;
```

**3. Сотрудники, чьё имя начинается на «А»**

``` sql
SELECT *
FROM Employees
WHERE EmployeeName LIKE N'А%';
```

**4. Сотрудники из отдела с `DepartmentId = 2`**

``` sql
SELECT *
FROM Employees
WHERE DepartmentId = 2;
```

**5. Сотрудники с зарплатой от 40000 до 60000 включительно**

``` sql
SELECT *
FROM Employees
WHERE Salary BETWEEN 40000 AND 60000;
```

### Результат

После выполнения каждого запроса должна отображаться выборка
сотрудников, соответствующих условию. При исходных тестовых данных все
пять запросов возвращают непустой результат.

**Фактический результат / скриншоты:** добавить из SSMS.

### Вывод

`SELECT` выбирает данные из таблицы, а `WHERE` фильтрует строки по
условию. `LIKE` ищет по шаблону, `YEAR` извлекает год из даты, а
`BETWEEN` проверяет попадание значения в диапазон, включая его границы.

------------------------------------------------------------------------

## Task 04 --- ORDER BY + TOP: сортировка и лимит

### Запрос

**1. Три сотрудника с наибольшей зарплатой**

``` sql
SELECT TOP 3 *
FROM Employees
ORDER BY Salary DESC;
```

**2. Пять самых давно работающих сотрудников**

``` sql
SELECT TOP 5 *
FROM Employees
ORDER BY HireDate ASC;
```

**3. Сортировка сначала по отделу, затем по зарплате**

``` sql
SELECT *
FROM Employees
ORDER BY DepartmentId ASC, Salary DESC;
```

### Результат

Первый запрос возвращает три строки с наибольшими зарплатами. Второй ---
пять сотрудников с наиболее ранними датами найма. Третий сортирует
сотрудников по номеру отдела, а внутри отдела --- по убыванию зарплаты.

**Фактический результат / скриншоты:** добавить из SSMS.

### Вывод

`ORDER BY` задаёт порядок сортировки. `ASC` означает сортировку по
возрастанию, `DESC` --- по убыванию. `TOP` ограничивает количество
возвращаемых строк.

------------------------------------------------------------------------

## Task 05 --- Агрегация: COUNT, SUM, AVG, MIN, MAX

### Запрос

``` sql
SELECT
    COUNT(*) AS EmployeeCount,
    SUM(Salary) AS TotalSalary,
    ROUND(AVG(Salary), 2) AS AverageSalary,
    MIN(Salary) AS MinimumSalary,
    MAX(Salary) AS MaximumSalary
FROM Employees;
```

Количество сотрудников с зарплатой больше 50000:

``` sql
SELECT COUNT(*) AS EmployeesOver50000
FROM Employees
WHERE Salary > 50000;
```

### Результат

Для исходных тестовых данных ожидаются следующие значения:

  Показатель                                Значение
  -------------------------------------- -----------
  Количество сотрудников                          10
  Сумма зарплат                            589000.00
  Средняя зарплата                          58900.00
  Минимальная зарплата                      43000.00
  Максимальная зарплата                     90000.00
  Сотрудников с зарплатой больше 50000             7

**Фактический результат:** сверить с результатом SSMS.

### Вывод

Агрегатные функции позволяют получать общую статистику по данным:
считать строки, сумму, среднее, минимальное и максимальное значения.
`ROUND` округляет среднюю зарплату до двух знаков после запятой.

------------------------------------------------------------------------

## Task 06 --- GROUP BY: статистика по отделам

### Запрос

``` sql
SELECT
    DepartmentId,
    COUNT(*) AS EmployeeCount,
    AVG(Salary) AS AverageSalary,
    SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentId
ORDER BY AverageSalary DESC;
```

### Результат

Для исходных тестовых данных ожидается:

    DepartmentId   EmployeeCount   AverageSalary   TotalSalary
  -------------- --------------- --------------- -------------
               4               1        90000.00      90000.00
               1               4        60000.00     240000.00
               2               3        57000.00     171000.00
               3               2        44000.00      88000.00

**Фактический результат:** сверить с результатом SSMS.

### Вывод

`GROUP BY` объединяет строки с одинаковым значением `DepartmentId` в
группы. Агрегатные функции вычисляют показатели отдельно для каждой
группы. `ORDER BY` сортирует отделы по средней зарплате по убыванию.

------------------------------------------------------------------------

## Task 07 --- GROUP BY + HAVING: фильтрация групп

### Запрос

**1. Отделы, в которых больше двух сотрудников**

``` sql
SELECT
    DepartmentId,
    COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY DepartmentId
HAVING COUNT(*) > 2;
```

**2. Отделы со средней зарплатой больше 55000**

``` sql
SELECT
    DepartmentId,
    AVG(Salary) AS AverageSalary
FROM Employees
GROUP BY DepartmentId
HAVING AVG(Salary) > 55000;
```

**3. Отделы, где суммарная зарплата больше 150000**

``` sql
SELECT
    DepartmentId,
    SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentId
HAVING SUM(Salary) > 150000;
```

### Результат

Для исходных тестовых данных:

-   В первом запросе должны остаться отделы 1 и 2.
-   Во втором запросе должны остаться отделы 1, 2 и 4.
-   В третьем запросе должны остаться отделы 1 и 2.

**Фактический результат:** сверить с результатом SSMS.

### Вывод

`HAVING` фильтрует группы после выполнения `GROUP BY`. В отличие от
`WHERE`, его можно использовать для условий с агрегатными функциями,
например `COUNT`, `AVG` и `SUM`.

------------------------------------------------------------------------

## Task 08 --- INNER JOIN: сотрудники и отделы

### Запрос

``` sql
SELECT
    Employees.EmployeeName,
    Departments.DepartmentName,
    Employees.Salary
FROM Employees
INNER JOIN Departments
    ON Employees.DepartmentId = Departments.DepartmentId
ORDER BY
    Departments.DepartmentName ASC,
    Employees.Salary DESC;
```

### Результат

Запрос выводит имя каждого сотрудника, название его отдела и зарплату.
При исходных данных должны вернуться 10 строк.

**Фактический результат / скриншот:** добавить из SSMS.

### Вывод

`INNER JOIN` объединяет строки двух таблиц по условию из `ON`. В
результат попадают только строки, для которых найдено совпадение в обеих
таблицах.

------------------------------------------------------------------------

## Task 09 --- LEFT JOIN: сотрудники без проектов

### Запрос

``` sql
SELECT
    Employees.EmployeeId,
    Employees.EmployeeName
FROM Employees
LEFT JOIN EmployeeProjects
    ON Employees.EmployeeId = EmployeeProjects.EmployeeId
WHERE EmployeeProjects.EmployeeId IS NULL;
```

### Результат

При исходных тестовых данных ожидается сотрудник:

    EmployeeId EmployeeName
  ------------ ------------------
             9 Наталья Соколова

**Фактический результат:** сверить с результатом SSMS.

### Вывод

`LEFT JOIN` сохраняет все строки из левой таблицы, даже если
соответствия в правой таблице нет. Для поиска строк без совпадения
используется проверка `IS NULL`.

------------------------------------------------------------------------

## Task 10 --- Множественный JOIN: сотрудники, отделы, проекты

### Запрос

``` sql
SELECT
    Employees.EmployeeName,
    Departments.DepartmentName,
    Projects.ProjectName,
    EmployeeProjects.Hours
FROM Employees
INNER JOIN Departments
    ON Employees.DepartmentId = Departments.DepartmentId
INNER JOIN EmployeeProjects
    ON Employees.EmployeeId = EmployeeProjects.EmployeeId
INNER JOIN Projects
    ON EmployeeProjects.ProjectId = Projects.ProjectId
ORDER BY
    Departments.DepartmentName ASC,
    Employees.EmployeeName ASC,
    Projects.ProjectName ASC;
```

### Результат

Запрос выводит сотрудника, его отдел, название назначенного проекта и
количество часов. При исходных тестовых данных ожидается 14 строк --- по
одной строке на каждое назначение сотрудника на проект.

**Фактический результат / скриншот:** добавить из SSMS.

### Вывод

Несколько `INNER JOIN` позволяют объединить данные из четырёх связанных
таблиц. Связи выполняются по первичным и внешним ключам. Результат
отсортирован по отделу, сотруднику и проекту.

------------------------------------------------------------------------

## Примечание

Результаты и скриншоты в разделах заданий нужно сверить с фактическим
выполнением запросов в SSMS. Если тестовые данные в `PracticeDB`
изменялись, ожидаемые количества и значения могут отличаться.

