﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Data.Entity.Tools.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Data.Entity.Tools.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assembly to use..
        /// </summary>
        internal static string AssemblyDescription {
            get {
                return ResourceManager.GetString("AssemblyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can use the Add-Migration command to write the pending model changes to a code-based migration..
        /// </summary>
        internal static string AutomaticMigrationDisabledInfo {
            get {
                return ResourceManager.GetString("AutomaticMigrationDisabledInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the configuration file to use for named connection strings..
        /// </summary>
        internal static string ConfigDescription {
            get {
                return ResourceManager.GetString("ConfigDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the provider invariant name of the connection string..
        /// </summary>
        internal static string ConnectionProviderDescription {
            get {
                return ResourceManager.GetString("ConnectionProviderDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the connection string to use. If omitted, the context&apos;s default connection will be used..
        /// </summary>
        internal static string ConnectionStringDescription {
            get {
                return ResourceManager.GetString("ConnectionStringDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the name of a connection string to use from the application&apos;s configuration file..
        /// </summary>
        internal static string ConnectionStringNameDescription {
            get {
                return ResourceManager.GetString("ConnectionStringNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the name of the assembly which contains the DbContext class to use. If omitted, the context is assumed to be in the same assembly used for migrations..
        /// </summary>
        internal static string ContextAssemblyDescription {
            get {
                return ResourceManager.GetString("ContextAssemblyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the context to use. If omitted, migrations will attempt to locate a single context type in the target project..
        /// </summary>
        internal static string ContextDescription {
            get {
                return ResourceManager.GetString("ContextDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commands to manage the database..
        /// </summary>
        internal static string DatabaseDescription {
            get {
                return ResourceManager.GetString("DatabaseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Applies any pending migrations to the database..
        /// </summary>
        internal static string DatabaseUpdateDescription {
            get {
                return ResourceManager.GetString("DatabaseUpdateDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies that data loss is acceptable during automatic migration of the database..
        /// </summary>
        internal static string DatabaseUpdateForceDescription {
            get {
                return ResourceManager.GetString("DatabaseUpdateForceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate a SQL script rather than executing the pending changes directly..
        /// </summary>
        internal static string DatabaseUpdateScriptDescription {
            get {
                return ResourceManager.GetString("DatabaseUpdateScriptDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only valid with --script. Specifies the name of a particular migration to use as the update&apos;s starting point. If omitted, the last applied migration in the database will be used..
        /// </summary>
        internal static string DatabaseUpdateSourceDescription {
            get {
                return ResourceManager.GetString("DatabaseUpdateSourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the name of a particular migration to update the database to. If omitted, the current model will be used..
        /// </summary>
        internal static string DatabaseUpdateTargetDescription {
            get {
                return ResourceManager.GetString("DatabaseUpdateTargetDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data directory..
        /// </summary>
        internal static string DataDirDescription {
            get {
                return ResourceManager.GetString("DataDirDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A previous migration called &apos;{0}&apos; was already applied to the target database. If you meant to re-scaffold &apos;{0}&apos;, revert it by running &apos;Update-Database -TargetMigration {1}&apos;, then delete &apos;{2}&apos; and run &apos;Add-Migration {0}&apos; again..
        /// </summary>
        internal static string DidYouMeanToRescaffold {
            get {
                return ResourceManager.GetString("DidYouMeanToRescaffold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity Framework Command-line Tools.
        /// </summary>
        internal static string EF6FullName {
            get {
                return ResourceManager.GetString("EF6FullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking if the context targets an existing database....
        /// </summary>
        internal static string EnableMigrations_BeginInitialScaffold {
            get {
                return ResourceManager.GetString("EnableMigrations_BeginInitialScaffold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detected database created with a database initializer. Scaffolded migration &apos;{0}&apos; corresponding to existing database. To use an automatic migration instead, delete the Migrations folder and re-run Enable-Migrations specifying the -EnableAutomaticMigrations parameter..
        /// </summary>
        internal static string EnableMigrations_InitialScaffold {
            get {
                return ResourceManager.GetString("EnableMigrations_InitialScaffold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code First Migrations enabled for project {0}..
        /// </summary>
        internal static string EnableMigrations_Success {
            get {
                return ResourceManager.GetString("EnableMigrations_Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your target project &apos;{0}&apos; doesn&apos;t reference EntityFramework. This package is required for the Entity Framework Core Tools to work. Ensure your target project is correct, install the package, and try again..
        /// </summary>
        internal static string EntityFrameworkNotFound {
            get {
                return ResourceManager.GetString("EntityFrameworkNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving migrations that have been applied to the target database..
        /// </summary>
        internal static string GetMigrationsCommand_Intro {
            get {
                return ResourceManager.GetString("GetMigrationsCommand_Intro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No migrations have been applied to the target database..
        /// </summary>
        internal static string GetMigrationsCommand_NoHistory {
            get {
                return ResourceManager.GetString("GetMigrationsCommand_NoHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scaffolds an empty migration ignoring any pending changes detected in the current model. This can be used to create an initial, empty migration to enable Migrations for an existing database. N.B. Doing this assumes that the target database schema is compatible with the current model..
        /// </summary>
        internal static string IgnoreChangesDescription {
            get {
                return ResourceManager.GetString("IgnoreChangesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show JSON output..
        /// </summary>
        internal static string JsonDescription {
            get {
                return ResourceManager.GetString("JsonDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The language. Defaults to &apos;C#&apos;..
        /// </summary>
        internal static string LanguageDescription {
            get {
                return ResourceManager.GetString("LanguageDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the name of the custom script..
        /// </summary>
        internal static string MigrationNameDescription {
            get {
                return ResourceManager.GetString("MigrationNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scaffolds a migration script for any pending model changes..
        /// </summary>
        internal static string MigrationsAddDescription {
            get {
                return ResourceManager.GetString("MigrationsAddDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies that the migration user code be overwritten when re-scaffolding an existing migration..
        /// </summary>
        internal static string MigrationsAddForceDescription {
            get {
                return ResourceManager.GetString("MigrationsAddForceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Migrations have already been enabled in project &apos;{0}&apos;. To overwrite the existing migrations configuration, use the -Force parameter..
        /// </summary>
        internal static string MigrationsAlreadyEnabled {
            get {
                return ResourceManager.GetString("MigrationsAlreadyEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the migrations configuration to use. If omitted, migrations will attempt to locate a single migrations configuration type in the target project..
        /// </summary>
        internal static string MigrationsConfigDescription {
            get {
                return ResourceManager.GetString("MigrationsConfigDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commands to manage migrations..
        /// </summary>
        internal static string MigrationsDescription {
            get {
                return ResourceManager.GetString("MigrationsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the name of the directory that will contain migrations code files. If omitted, the directory will be named &quot;Migrations&quot;..
        /// </summary>
        internal static string MigrationsDirDescription {
            get {
                return ResourceManager.GetString("MigrationsDirDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;MigrationsDirectory&apos; parameter was set to the absolute path &apos;{0}&apos;. The migrations directory must be set to a relative path for a sub-directory under the Visual Studio project root..
        /// </summary>
        internal static string MigrationsDirectoryParamIsRooted {
            get {
                return ResourceManager.GetString("MigrationsDirectoryParamIsRooted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies whether automatic migrations will be enabled in the scaffolded migrations configuration. If omitted, automatic migrations will be disabled..
        /// </summary>
        internal static string MigrationsEnableAutoDescription {
            get {
                return ResourceManager.GetString("MigrationsEnableAutoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enables Code First Migrations in a project..
        /// </summary>
        internal static string MigrationsEnableDescription {
            get {
                return ResourceManager.GetString("MigrationsEnableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies that the migrations configuration be overwritten when running more than once for a given project..
        /// </summary>
        internal static string MigrationsEnableForceDescription {
            get {
                return ResourceManager.GetString("MigrationsEnableForceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays the migrations that have been applied to the target database..
        /// </summary>
        internal static string MigrationsListDescription {
            get {
                return ResourceManager.GetString("MigrationsListDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing required argument &apos;{0}&apos;..
        /// </summary>
        internal static string MissingArgument {
            get {
                return ResourceManager.GetString("MissingArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing required option &apos;--{0}&apos;..
        /// </summary>
        internal static string MissingOption {
            get {
                return ResourceManager.GetString("MissingOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify either option &apos;--{0}&apos; or &apos;--{2}&apos;, but not both..
        /// </summary>
        internal static string MutuallyExclusiveOptions {
            get {
                return ResourceManager.GetString("MutuallyExclusiveOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t colorize output..
        /// </summary>
        internal static string NoColorDescription {
            get {
                return ResourceManager.GetString("NoColorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefix output with level..
        /// </summary>
        internal static string PrefixDescription {
            get {
                return ResourceManager.GetString("PrefixDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project directory. Defaults to the current directory..
        /// </summary>
        internal static string ProjectDirDescription {
            get {
                return ResourceManager.GetString("ProjectDirDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Re-scaffolding migration &apos;{0}&apos;..
        /// </summary>
        internal static string RescaffoldingMigration {
            get {
                return ResourceManager.GetString("RescaffoldingMigration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only the Designer Code for migration &apos;{0}&apos; was re-scaffolded. To re-scaffold the entire migration, use the -Force parameter..
        /// </summary>
        internal static string RescaffoldNoForce {
            get {
                return ResourceManager.GetString("RescaffoldNoForce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The root namespace. Defaults to the target assembly name..
        /// </summary>
        internal static string RootNamespaceDescription {
            get {
                return ResourceManager.GetString("RootNamespaceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scaffolding migration &apos;{0}&apos;..
        /// </summary>
        internal static string ScaffoldingMigration {
            get {
                return ResourceManager.GetString("ScaffoldingMigration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running &apos;Add-Migration {0}&apos; again..
        /// </summary>
        internal static string SnapshotBehindWarning {
            get {
                return ResourceManager.GetString("SnapshotBehindWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify the &apos;-Verbose&apos; flag to view the SQL statements being applied to the target database..
        /// </summary>
        internal static string UpdateDatabaseCommand_VerboseInstructions {
            get {
                return ResourceManager.GetString("UpdateDatabaseCommand_VerboseInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show verbose output..
        /// </summary>
        internal static string VerboseDescription {
            get {
                return ResourceManager.GetString("VerboseDescription", resourceCulture);
            }
        }
    }
}
