﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Остат на склад.
    /// </summary>
    // *** Start programmer edit section *** (ОстатНаСклад CustomAttributes)

    // *** End programmer edit section *** (ОстатНаСклад CustomAttributes)
    [AutoAltered()]
    [Caption("Остатки на складе")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОстатНаСкладE", new string[] {
            "Дата as \'Дата\'",
            "Организации as \'Организации\'",
            "Организации.Организация as \'Организация\'",
            "Склады as \'Склады\'",
            "Склады.Склад as \'Склад\'",
            "Номенклатуры as \'Номенклатуры\'",
            "Номенклатуры.Номенклатура as \'Номенклатура\'",
            "Номенклатуры.ЕдИзмер.ЕдИзмер as \'Единица измерения\'",
            "Колл as \'Количество\'"}, Hidden=new string[] {
            "Организации.Организация",
            "Склады.Склад",
            "Номенклатуры.Номенклатура"})]
    [MasterViewDefineAttribute("ОстатНаСкладE", "Организации", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Организация")]
    [MasterViewDefineAttribute("ОстатНаСкладE", "Склады", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Склад")]
    [MasterViewDefineAttribute("ОстатНаСкладE", "Номенклатуры", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Номенклатура")]
    [View("ОстатНаСкладL", new string[] {
            "Дата as \'Дата\'",
            "Колл as \'Колл\'",
            "Склады.Склад as \'Склад\'",
            "Организации.Организация as \'Организация\'",
            "Номенклатуры.Номенклатура as \'Номенклатура\'"})]
    public class ОстатНаСклад : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private int fКолл;
        
        private IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Склады fСклады;
        
        private IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Организации fОрганизации;
        
        private IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Номенклатуры fНоменклатуры;
        
        // *** Start programmer edit section *** (ОстатНаСклад CustomMembers)

        // *** End programmer edit section *** (ОстатНаСклад CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ОстатНаСклад.Дата CustomAttributes)

        // *** End programmer edit section *** (ОстатНаСклад.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Дата Get start)

                // *** End programmer edit section *** (ОстатНаСклад.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ОстатНаСклад.Дата Get end)

                // *** End programmer edit section *** (ОстатНаСклад.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Дата Set start)

                // *** End programmer edit section *** (ОстатНаСклад.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ОстатНаСклад.Дата Set end)

                // *** End programmer edit section *** (ОстатНаСклад.Дата Set end)
            }
        }
        
        /// <summary>
        /// Колл.
        /// </summary>
        // *** Start programmer edit section *** (ОстатНаСклад.Колл CustomAttributes)

        // *** End programmer edit section *** (ОстатНаСклад.Колл CustomAttributes)
        public virtual int Колл
        {
            get
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Колл Get start)

                // *** End programmer edit section *** (ОстатНаСклад.Колл Get start)
                int result = this.fКолл;
                // *** Start programmer edit section *** (ОстатНаСклад.Колл Get end)

                // *** End programmer edit section *** (ОстатНаСклад.Колл Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Колл Set start)

                // *** End programmer edit section *** (ОстатНаСклад.Колл Set start)
                this.fКолл = value;
                // *** Start programmer edit section *** (ОстатНаСклад.Колл Set end)

                // *** End programmer edit section *** (ОстатНаСклад.Колл Set end)
            }
        }
        
        /// <summary>
        /// Остат на склад.
        /// </summary>
        // *** Start programmer edit section *** (ОстатНаСклад.Номенклатуры CustomAttributes)

        // *** End programmer edit section *** (ОстатНаСклад.Номенклатуры CustomAttributes)
        [PropertyStorage(new string[] {
                "Номенклатуры"})]
        [NotNull()]
        public virtual IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Номенклатуры Номенклатуры
        {
            get
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Номенклатуры Get start)

                // *** End programmer edit section *** (ОстатНаСклад.Номенклатуры Get start)
                IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Номенклатуры result = this.fНоменклатуры;
                // *** Start programmer edit section *** (ОстатНаСклад.Номенклатуры Get end)

                // *** End programmer edit section *** (ОстатНаСклад.Номенклатуры Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Номенклатуры Set start)

                // *** End programmer edit section *** (ОстатНаСклад.Номенклатуры Set start)
                this.fНоменклатуры = value;
                // *** Start programmer edit section *** (ОстатНаСклад.Номенклатуры Set end)

                // *** End programmer edit section *** (ОстатНаСклад.Номенклатуры Set end)
            }
        }
        
        /// <summary>
        /// Остат на склад.
        /// </summary>
        // *** Start programmer edit section *** (ОстатНаСклад.Организации CustomAttributes)

        // *** End programmer edit section *** (ОстатНаСклад.Организации CustomAttributes)
        [PropertyStorage(new string[] {
                "Организации"})]
        [NotNull()]
        public virtual IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Организации Организации
        {
            get
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Организации Get start)

                // *** End programmer edit section *** (ОстатНаСклад.Организации Get start)
                IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Организации result = this.fОрганизации;
                // *** Start programmer edit section *** (ОстатНаСклад.Организации Get end)

                // *** End programmer edit section *** (ОстатНаСклад.Организации Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Организации Set start)

                // *** End programmer edit section *** (ОстатНаСклад.Организации Set start)
                this.fОрганизации = value;
                // *** Start programmer edit section *** (ОстатНаСклад.Организации Set end)

                // *** End programmer edit section *** (ОстатНаСклад.Организации Set end)
            }
        }
        
        /// <summary>
        /// Остат на склад.
        /// </summary>
        // *** Start programmer edit section *** (ОстатНаСклад.Склады CustomAttributes)

        // *** End programmer edit section *** (ОстатНаСклад.Склады CustomAttributes)
        [PropertyStorage(new string[] {
                "Склады"})]
        [NotNull()]
        public virtual IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Склады Склады
        {
            get
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Склады Get start)

                // *** End programmer edit section *** (ОстатНаСклад.Склады Get start)
                IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.Склады result = this.fСклады;
                // *** Start programmer edit section *** (ОстатНаСклад.Склады Get end)

                // *** End programmer edit section *** (ОстатНаСклад.Склады Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОстатНаСклад.Склады Set start)

                // *** End programmer edit section *** (ОстатНаСклад.Склады Set start)
                this.fСклады = value;
                // *** Start programmer edit section *** (ОстатНаСклад.Склады Set end)

                // *** End programmer edit section *** (ОстатНаСклад.Склады Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОстатНаСкладE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОстатНаСкладE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОстатНаСкладE", typeof(IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.ОстатНаСклад));
                }
            }
            
            /// <summary>
            /// "ОстатНаСкладL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОстатНаСкладL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОстатНаСкладL", typeof(IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.ОстатНаСклад));
                }
            }
        }
    }
}
