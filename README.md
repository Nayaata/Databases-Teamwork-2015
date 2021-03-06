<p align="center">
	<a href="http://academy.telerik.com/">
		<img src="https://raw.githubusercontent.com/lnikod4s/Telerik-Software-Academy/master/Modul%201/Sources/telerik-logo.png" />
	</a>
</p>

- - -

# Databases Teamwork October 2015

## Table Of Contents

* [Contributors](#contributors)
* [Installed Nuget Packages](#installed-nuget-packages)
* [Project Description](#project-description)
* [Problem 1](#problem-1)
* [Problem 2](#problem-2)
* [Problem 3](#problem-3)
* [Problem 4](#problem-4)
* [Problem 5](#problem-5)
* [Problem 6](#problem-6)
* [Additional Requirements](#additional-requirements)

## Contributors

* __lnikod4s__ - Lyudmil Nikodimov ([@lnikod4s](https://github.com/lnikod4s))
* __Nayata__ - Niya Keranova ([@NayaIT](https://github.com/NayaIT))
* __S.Daskalov__ - Stanimir Daskalov ([@S.Daskalov](https://github.com/SDaskalov))

## Installed Nuget Packages
* DocumentFormat.OpenXml.2.5
* DotNetZip.1.9.6
* EntityFramework.6.1.3
* ExcelFile.net.1.1.1
* mongocsharpdriver.2.0.1
* MongoDB.Bson.2.0.1
* MongoDB.Driver.2.0.1
* MongoDB.Driver.Core.2.0.1
* MySql.Data.6.8.6
* MySql.Data.6.9.7
* MySql.Data.Entities.6.8.3.0
* MySql.Data.Entity.6.9.7
* Newtonsoft.Json.7.0.1
* NPOI.2.0.6
* PDFsharp.1.32.3057.0
* PDFsharp-MigraDoc-GDI.1.32.4334.0
* SharpZipLib.0.86.0
* System.Data.SQLite.1.0.98.1
* System.Data.SQLite.Core.1.0.98.1
* System.Data.SQLite.EF6.1.0.98.1
* System.Data.SQLite.Linq.1.0.98.1
* Telerik.DataAccess.Core.2013.3.1320.1
* Telerik.DataAccess.Core.2015.3.926.1
* Telerik.DataAccess.Fluent.2013.3.1320.1
* Telerik.DataAccess.Fluent.2015.3.926.1

## Project Description

* Your assignment is to design, develop and test a C# application for importing Excel reports from a ZIP file and the product data from MongoDB into SQL Server, generate XML reports and PDF reports, create reports as JSON documents and also load them into MySQL, load additional information by your choice from XML file, read other information by your choice from SQLite and calculate aggregated results and write them into Excel file:

![project](https://cloud.githubusercontent.com/assets/3619393/10135708/e4b681d4-65f8-11e5-9243-0aea8fa008eb.png)

* All reports should be different from each other and are by your choice. They can be sales reports, taxes reports, vendor reports, etc. Try to use real-world example.

[Back to top &#8593;](#table-of-contents)

## Problem 1
### Load Excel Reports from ZIP File

* Your task is to write a C# program to **load Excel in MS SQL Server**. You may need to preliminary design a database schema to hold all data about the products (data from the MongoDB database and data from the Excel files) or use the "code-first" approach to move the DB schema from MongoDB to SQL Server. Your C# program should also move the products data from MongoDB to SQL Server.
* The Excel files are given inside a **ZIP archive** holding subfolders named as the dates of the report in format **dd-MMM-yyyy** (see the example reports archive [Sample-Sales-Reports.zip](https://github.com/Team-Tower-Databases-Online/Databases-Teamwork-2015/blob/master/Samples/Sample-Sales-Reports.zip)).
* Note that the ZIP file could contain few hundred dates (folders), each holding few hundreds Excel files, each holding thousands of data.
* **Input**: MongoDB database, ZIP file with Excel 2003 reports. **Output**: data loaded in the SQL Server database.
* _For example:_
  * You may have the **MongoDB database “Supermarket”** holding information about some vendors and some products and a **set of Excel files** (*.xls) holding information about the sales in the different supermarkets.



* A sample PDF report is also available: [Sample-Aggregated-Sales-Report.pdf](https://github.com/Team-Tower-Databases-Online/Databases-Teamwork-2015/blob/master/Samples/Sample-Aggregated-Sales-Report.pdf).
* **Input**:
  * SQL Server database
* **Output**:
  * PDF report

[Back to top &#8593;](#table-of-contents)

## Problem 2
### Generate PDF Reports

* Your task is to generate a PDF reports summarizing information from the SQL Server.
* _For example:_
  * The PDF report may contain a table like the sample below:
[Sample-Aggregated-Sales-Report.pdf](https://github.com/Team-Tower-Databases-Online/Databases-Teamwork-2015/blob/master/Samples/Sample-Aggregated-Sales-Report.pdf)

[Back to top &#8593;](#table-of-contents)

## Problem 3
### Generate XML Report

* Your task is to create a C# program to **generate report in XML format** like the sample below:

**Sales-by-Vendors-report.xml**
```xml
<?xml version="1.0" encoding="utf-8">
<sales>
  <sale vendor="Nestle Sofia Corp.">
    <summary date="20-Jul-2013" total-sum="54.75" />
    <summary date="21-Jul-2013" total-sum="40.35" />
    <summary date="22-Jul-2013" total-sum="40.60" />
  </sale>
  <sale vendor="Targovishte Bottling Company Ltd.">
    <summary date="20-Jul-2013" total-sum="150.20" />
    <summary date="21-Jul-2013" total-sum="709.30" />
    <summary date="22-Jul-2013" total-sum="249.40" />
  </sale>
  <sale vendor="Zagorka Corp.">
    <summary date="20-Jul-2013" total-sum="144.80" />
    <summary date="21-Jul-2013" total-sum="341.59" />
    <summary date="22-Jul-2013" total-sum="385.80" />
  </sale>
<sales>
```

* Save the report in an “**xml**” file.
* **Input**:
  * SQL Server database
* **Output**:
  * XML report

[Back to top &#8593;](#table-of-contents)

## Problem 4
### JSON Reports

* Your task is to write a program to create report for each product in JSON format and save all reports in MySQL. All reports may look like the sample below and should be saved in the MySQL database as well as in the file system (in a folder called “Json-Reports”, in files named “XX.json” where XX is the ID).
* Sample product report in JSON format:

**3.json**
```javascript
{
  "product-id" : 3,
  "product-name" : "Beer “Beck’s”",
  "vendor-name" : "Zagorka Corp.",
  "total-quantity-sold" : 236,
  "total-incomes" : 262.95,
}
```
**1.json**
```javascript
{
  "product-id" : 1,
  "product-name" : "Beer “Zagorka”",
  "vendor-name" : "Zagorka Corp.",
  "total-quantity-sold" : 673,
  "total-incomes" : 609.24,
}
```
**4.json**
```javascript
{
  "product-id" : 4,
  "product-name" : "Chocolate “Milka”",
  "vendor-name" : "Nestle Sofia Corp.",
  "total-quantity-sold" : 47,
  "total-incomes" : 135.70,
}
```
**2.json**
```javascript
{
  "product-id" : 2,
  "product-name" : "Vodka “Targovishte”",
  "vendor-name" : "Targovishte Bottling Company Ltd.",
  "total-quantity-sold" : 144,
  "total-incomes" : 1155.90,
}
```

* **Input**:
  * SQL Server database
* **Output**:
  * A set of JSON files
  * Data loaded in MySQL database

[Back to top &#8593;](#table-of-contents)

## Problem 5
### Load data from XML

* You must create **XML** file holding additional information by your choice.
* _For example:_

**Vendors-Expenses.xml**
```xml
<?xml version="1.0" encoding="utf-8">
<expenses-by-month>
  <vendor name="Nestle Sofia Corp.">
    <expenses month="Jul-2013">30.00</expenses>
    <expenses month="Aug-2013">40.00</expenses>
  </vendor>
  <vendor name="Targovishte Bottling Company Ltd.">
    <expenses month="Jul-2013">200.00</expenses>
    <expenses month="Aug-2013">180.00</expenses>
  </vendor>
  <vendor name="Zagorka Corp.">
    <expenses month="Jul-2013">120.00</expenses>
    <expenses month="Aug-2013">180.00</expenses>
  </vendor>
<expenses-by-month>
```

* Your task is to **read the XML file**, parse it and **save the data** in the ***MongoDB** database and in the **SQL Server**. Please think how your database schema / document model will support the additional data.
* **Input**:
  * XML file
* **Output**:
  * Data loaded in the SQL Server
  * Data loaded in the MongoDB

[Back to top &#8593;](#table-of-contents)

## Problem 6
### Excel data

* You are given a **SQLite database** holding more information for each product.
* _For example:_

|    Product Name           |    Tax    |
|---------------------------|:---------:|
|    Beer “Beck’s”          |    20%    |
|    Beer “Zagorka”         |    20%    |
|    Chocolate   “Milka”    |    18%    |
|    Vodka “Targovishte”    |    25%    |

* Write a program to **read the MySQL database** of reports, **read the information from SQLite** and generate a **single Excel 2007** file holding some information by your choice.
* _For example:_

|    Vendor                               |    Incomes    |    Expenses    |    Taxes     |    Financial Result    |
|-----------------------------------------|:-------------:|----------------|--------------|------------------------|
|    Nestle Sofia Corp.                   |    135.70     |    30          |    24.43     |    81.27               |
|    Targovishte Bottling Company Ltd.    |    1155.90    |    200         |    288.98    |    666.92              |
|    Zagorka Corp.                        |    872.19     |    120         |    174.44    |    577.75              |

* You are **not** allowed to connect to the SQL Server or MongoDB databases to read information.
* **Input**:
  * SQLite database
  * MySQL database
* **Output**:
  * Excel 2007 file (.xlsx)

[Back to top &#8593;](#table-of-contents)

## Additional Requirements

*	Your main program logic should be a C# application (a set of modules, executed sequentially one after another).
*	Use non-commercial library to read the ZIP file.
*	For reading the Excel 2003 files (.xls) use ADO.NET (without ORM or third-party libraries).
*	MySQL should be accessed through OpenAccess ORM (research it)
*	SQL Server should be accessed through Entity Framework.
*	You are free to use "code first" or "database first" approach or both for the ORM frameworks.
*	For the PDF export use a non-commercial third party framework.
*	The XML files should be read / written through the standard .NET parsers (by your choice).
*	For JSON serializations use a non-commercial library / framework of your choice.
*	MongoDB should be accessed through the Official MongoDB C# Driver.
*	The SQLite embedded database should be accesses though its Entity Framework provider.
*	For creating the Excel 2007 files (.xlsx) use a third-party non-commercial library.

[Back to top &#8593;](#table-of-contents)
