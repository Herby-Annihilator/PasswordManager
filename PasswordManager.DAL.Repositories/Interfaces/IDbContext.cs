﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// Предоставляет подключение к базе данных
        /// </summary>
        IDbConnection Connection { get; }

        /// <summary>
        /// Предоставляет строитель команд
        /// </summary>
        IDbCommandBuilder CommandBuilder { get; }
        /// <summary>
        /// Предоставляет генератор простейших sql-команд
        /// </summary>
        ICrudCommandsGenerator CommandGenerator { get; }
        /// <summary>
        /// Провайдер данных между таблицами и сущностями
        /// </summary>
        DbAttributesPropertiesProvider Provider { get; }
    }
}
