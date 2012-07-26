﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siringa.Engine.Interfaces
{
    public interface IInjectionStrategy
    {
        IQueryRunner QueryRunner { get; set; }
        string DbVulnerableVersionFrom { get;}
        string DbVulnerableVersionTo { get;}

        string Url {get; set;}
        string DisplayName { get;}

        string SelectedDb { get; set; }
        string SelectedTable { get; set; }

        bool TestIfVulnerable();

        string GetDbVersion();
        string GetDbUserName();
        string GetCurrentDbName();

        int GetTotalNoOfDbs();
        int GetTotalNoOfTables();
        int GetTotalNoOfColumns();

        string GetSingleDatabaseName(int startingFrom);
        string GetSingleTableName(int startingFrom);
        string GetSingleTableColumnName(int startingFrom);

        string GetSingleCustomQueryRow(string query);

        string GetMultipleDatabaseNames(int startingFrom,int count);
        string GetTableNames(int startingFrom,int count);
        string GetTableColumnName(int startingFrom,int count);

        string GetMultipleCustomQueryRow(string query,int count);
    }
}
