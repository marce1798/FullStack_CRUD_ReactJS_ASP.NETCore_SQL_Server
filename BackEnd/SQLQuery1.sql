create database DbManagers

use DbManagers

create table Db_Manager(
  id int primary key identity(1,1) not null,
  name varchar(50) not null,
  company varchar(50) not null,
  year_creation int not null
)

-- inserta datos de prueba
insert into Db_Manager(name, company, year_creation) values('Oracle', 'Oracle Corporation', 1977)
insert into Db_Manager(name, company, year_creation) values('MySQL', 'Oracle Corporation', 1995)
insert into Db_Manager(name, company, year_creation) values('PostgreSQL', 'PostgreSQL Global Development Group', 1996)
insert into Db_Manager(name, company, year_creation) values('SQL Server', 'Microsoft', 1989)
insert into Db_Manager(name, company, year_creation) values('SQLite', 'D. Richard Hipp', 2000)
insert into Db_Manager(name, company, year_creation) values('MariaDB', 'MariaDB Corporation Ab', 2009)
insert into Db_Manager(name, company, year_creation) values('MongoDB', 'MongoDB Inc.', 2009)
insert into Db_Manager(name, company, year_creation) values('CouchDB', 'Apache Software Foundation', 2005)
insert into Db_Manager(name, company, year_creation) values('Cassandra', 'Apache Software Foundation', 2008)
insert into Db_Manager(name, company, year_creation) values('Redis', 'Redis Labs', 2009)
insert into Db_Manager(name, company, year_creation) values('Neo4j', 'Neo4j Inc.', 2007)
insert into Db_Manager(name, company, year_creation) values('Couchbase', 'Couchbase Inc.', 2011)
insert into Db_Manager(name, company, year_creation) values('HBase', 'Apache Software Foundation', 2007)
insert into Db_Manager(name, company, year_creation) values('DynamoDB', 'Amazon', 2012)
insert into Db_Manager(name, company, year_creation) values('RethinkDB', 'RethinkDB', 2009)
insert into Db_Manager(name, company, year_creation) values('RavenDB', 'Hibernating Rhinos', 2009)
insert into Db_Manager(name, company, year_creation) values('ArangoDB', 'ArangoDB GmbH', 2012)
insert into Db_Manager(name, company, year_creation) values('CrateDB', 'Crate.io', 2013)
insert into Db_Manager(name, company, year_creation) values('ScyllaDB', 'ScyllaDB', 2015)
insert into Db_Manager(name, company, year_creation) values('InfluxDB', 'InfluxData', 2013)
