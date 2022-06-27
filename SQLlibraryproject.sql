/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/29/2022 11:58:33 AM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Admin') and o.name = 'FK_ADMIN_INHERITAN_USER')
alter table Admin
   drop constraint FK_ADMIN_INHERITAN_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Author') and o.name = 'FK_AUTHOR_INHERITAN_USER')
alter table Author
   drop constraint FK_AUTHOR_INHERITAN_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Document') and o.name = 'FK_DOCUMENT_CHECK_USER')
alter table Document
   drop constraint FK_DOCUMENT_CHECK_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Document') and o.name = 'FK_DOCUMENT_UPLOAD_ADMIN')
alter table Document
   drop constraint FK_DOCUMENT_UPLOAD_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reader') and o.name = 'FK_READER_INHERITAN_USER')
alter table Reader
   drop constraint FK_READER_INHERITAN_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SingningUp') and o.name = 'FK_SINGNING_SIGN2_USER')
alter table SingningUp
   drop constraint FK_SINGNING_SIGN2_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('buyer') and o.name = 'FK_BUYER_BUY_READER')
alter table buyer
   drop constraint FK_BUYER_BUY_READER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('sharingIdeas') and o.name = 'FK_SHARINGI_IDEAS_READER')
alter table sharingIdeas
   drop constraint FK_SHARINGI_IDEAS_READER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Admin')
            and   name  = 'Inheritance_admin_FK'
            and   indid > 0
            and   indid < 255)
   drop index Admin.Inheritance_admin_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Admin')
            and   type = 'U')
   drop table Admin
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Author')
            and   name  = 'Inheritance_author_FK'
            and   indid > 0
            and   indid < 255)
   drop index Author.Inheritance_author_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Author')
            and   type = 'U')
   drop table Author
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Document')
            and   name  = 'upload_FK'
            and   indid > 0
            and   indid < 255)
   drop index Document.upload_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Document')
            and   name  = 'check_FK'
            and   indid > 0
            and   indid < 255)
   drop index Document.check_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Document')
            and   type = 'U')
   drop table Document
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Reader')
            and   name  = 'Inheritance_reader_FK'
            and   indid > 0
            and   indid < 255)
   drop index Reader.Inheritance_reader_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Reader')
            and   type = 'U')
   drop table Reader
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SingningUp')
            and   name  = 'sign2_FK'
            and   indid > 0
            and   indid < 255)
   drop index SingningUp.sign2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SingningUp')
            and   type = 'U')
   drop table SingningUp
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('buyer')
            and   name  = 'buy_FK'
            and   indid > 0
            and   indid < 255)
   drop index buyer.buy_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('buyer')
            and   type = 'U')
   drop table buyer
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('sharingIdeas')
            and   name  = 'ideas_FK'
            and   indid > 0
            and   indid < 255)
   drop index sharingIdeas.ideas_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sharingIdeas')
            and   type = 'U')
   drop table sharingIdeas
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"user"')
            and   type = 'U')
   drop table "user"
go

/*==============================================================*/
/* Table: Admin                                                 */
/*==============================================================*/
create table Admin (
   SSN                  numeric(14)          not null,
   userName             varchar(25)          null,
   password             varchar(25)          null,
   constraint PK_ADMIN primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Index: Inheritance_admin_FK                                  */
/*==============================================================*/
create index Inheritance_admin_FK on Admin (
SSN ASC
)
go

/*==============================================================*/
/* Table: Author                                                */
/*==============================================================*/
create table Author (
   SSN                  numeric(14)          not null,
   userName             varchar(25)          null,
   password             varchar(25)          null,
   constraint PK_AUTHOR primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Index: Inheritance_author_FK                                 */
/*==============================================================*/
create index Inheritance_author_FK on Author (
SSN ASC
)
go

/*==============================================================*/
/* Table: Document                                              */
/*==============================================================*/
create table Document (
   title                varchar(25)          not null,
   BId                  numeric(14)          not null,
   SSN                  numeric(14)          null,
   price                money                not null,
   AuthorName           varchar(25)          not null,
   publishYear          numeric(4)           not null,
   category             varchar(25)          not null,
   constraint PK_DOCUMENT primary key nonclustered (BId)
)
go

/*==============================================================*/
/* Index: check_FK                                              */
/*==============================================================*/
create index check_FK on Document (
SSN ASC
)
go

/*==============================================================*/
/* Index: upload_FK                                             */
/*==============================================================*/
create index upload_FK on Document (
SSN ASC
)
go

/*==============================================================*/
/* Table: Reader                                                */
/*==============================================================*/
create table Reader (
   SSN                  numeric(14)          not null,
   userName             varchar(25)          null,
   password             varchar(25)          null,
   constraint PK_READER primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Index: Inheritance_reader_FK                                 */
/*==============================================================*/
create index Inheritance_reader_FK on Reader (
SSN ASC
)
go

/*==============================================================*/
/* Table: SingningUp                                            */
/*==============================================================*/
create table SingningUp (
   SSN                  numeric(14)          not null,
   username             varchar(25)          not null,
   password             varchar(25)          not null
)
go

/*==============================================================*/
/* Index: sign2_FK                                              */
/*==============================================================*/
create index sign2_FK on SingningUp (
SSN ASC
)
go

/*==============================================================*/
/* Table: buyer                                                 */
/*==============================================================*/
create table buyer (
   SSN                  numeric(14)          null,
   AuthorName           varchar(25)          not null,
   title                varchar(25)          not null,
   readerName           varchar(25)          not null
)
go

/*==============================================================*/
/* Index: buy_FK                                                */
/*==============================================================*/
create index buy_FK on buyer (
SSN ASC
)
go

/*==============================================================*/
/* Table: sharingIdeas                                          */
/*==============================================================*/
create table sharingIdeas (
   SSN                  numeric(14)          null,
   feedback             varchar(250)         not null,
   title                varchar(25)          not null
)
go

/*==============================================================*/
/* Index: ideas_FK                                              */
/*==============================================================*/
create index ideas_FK on sharingIdeas (
SSN ASC
)
go

/*==============================================================*/
/* Table: "user"                                                */
/*==============================================================*/
create table "user" (
   SSN                  numeric(14)          not null,
   userName             varchar(25)          null,
   password             varchar(25)          null,
   constraint PK_USER primary key nonclustered (SSN)
)
go

alter table Admin
   add constraint FK_ADMIN_INHERITAN_USER foreign key (SSN)
      references "user" (SSN)
go

alter table Author
   add constraint FK_AUTHOR_INHERITAN_USER foreign key (SSN)
      references "user" (SSN)
go

alter table Document
   add constraint FK_DOCUMENT_CHECK_USER foreign key (SSN)
      references "user" (SSN)
go

alter table Document
   add constraint FK_DOCUMENT_UPLOAD_ADMIN foreign key (SSN)
      references Admin (SSN)
go

alter table Reader
   add constraint FK_READER_INHERITAN_USER foreign key (SSN)
      references "user" (SSN)
go

alter table SingningUp
   add constraint FK_SINGNING_SIGN2_USER foreign key (SSN)
      references "user" (SSN)
go

alter table buyer
   add constraint FK_BUYER_BUY_READER foreign key (SSN)
      references Reader (SSN)
go



SELECT title, COUNT(title) as num_of_Books
FROM buyer  GROUP BY title 
HAVING COUNT (title)=( 
SELECT MAX(mycount) 
FROM ( 
SELECT title, COUNT(title) mycount 
FROM buyer 
GROUP BY title) as title );


Select title
From Document
Where ( title ) Not In
(Select title From buyer);

Select userName
From Author Where ( userName ) Not In 
(Select AuthorName From buyer);

Select count(userName) as num_of_authers From Author Where(userName) NOT In(Select AuthorName From buyer)and userName in (select AuthorName from Document); 


SELECT r.userName,r.password,r.SSN ,COUNT(b.title) AS numberofbooks
 FROM reader AS r
 LEFT JOIN buyer AS b ON b.SSN = r.SSN
 GROUP BY r.userName,r.password,r.SSN;

Select distinct count(AuthorName)
as num_of_authors From Document
Where ( AuthorName) NOT In       
(Select AuthorName From buyer) ;

Select userName From [dbo].[Author] Where ( userName ) Not In (Select AuthorName From [dbo].[Document]);




SELECT category , COUNT(title) as numberofbooks
FROM Document  GROUP BY category 
HAVING COUNT (title)=( 
SELECT min(mycount) 
FROM ( 
SELECT title, COUNT(title) mycount 
FROM Document
GROUP BY title) as title );



select * from [dbo].[user];
select * from [dbo].[Admin];
select * from [dbo].[Author];
select * from [dbo].[Reader];
select * from [dbo].[Document];
select * from [dbo].[buyer];
select * from [dbo].[SingningUp];
