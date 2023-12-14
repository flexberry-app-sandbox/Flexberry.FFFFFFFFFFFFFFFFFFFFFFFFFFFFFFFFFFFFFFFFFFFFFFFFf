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
    /// Заказ покуп.
    /// </summary>
    // *** Start programmer edit section *** (ЗаказПокуп CustomAttributes)

    // *** End programmer edit section *** (ЗаказПокуп CustomAttributes)
    [AutoAltered()]
    [Caption("Заказ покупателя")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаказПокупE", new string[] {
            "ДатаНачала as \'Дата начала\'",
            "ДатаОкончания as \'Дата окончания\'",
            "Организации as \'Организации\'",
            "Организации.Организация as \'Организация\'",
            "Подразеления as \'Подразеления\'",
            "Подразеления.Подразделение as \'Подразделение\'",
            "Склады as \'Склады\'",
            "Склады.Склад as \'Склад\'",
            "Контрагенты as \'Контрагенты\'",
            "Контрагенты.Контрагент as \'Контрагент\'",
            "СостОплат as \'Состояние оплаты\'",
            "СостОтгруз as \'Состояние отгрузки\'",
            "СумВклНДС as \'Сумма включая НДС\'",
            "Сумма as \'Сумма\'"}, Hidden=new string[] {
            "Организации.Организация",
            "Подразеления.Подразделение",
            "Склады.Склад",
            "Контрагенты.Контрагент"})]
    [AssociatedDetailViewAttribute("ЗаказПокупE", "ТЧТоварИУслуг", "ТЧТоварИУслугE", true, "", "Табличная часть товара и услуг", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ЗаказПокупE", "Организации", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Организация")]
    [MasterViewDefineAttribute("ЗаказПокупE", "Подразеления", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Подразделение")]
    [MasterViewDefineAttribute("ЗаказПокупE", "Склады", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Склад")]
    [MasterViewDefineAttribute("ЗаказПокупE", "Контрагенты", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Контрагент")]
    [View("ЗаказПокупL", new string[] {
            "ДатаОкончания as \'Дата окончания\'",
            "ДатаНачала as \'Дата начала\'",
            "СумВклНДС as \'Сум вкл НДС\'",
            "СостОтгруз as \'Сост отгруз\'",
            "СостОплат as \'Сост оплат\'",
            "Подразеления.Подразделение as \'Подразделение\'",
            "Склады.Склад as \'Склад\'",
            "Контрагенты.Контрагент as \'Контрагент\'",
            "Организации.Организация as \'Организация\'"})]
    public class ЗаказПокуп : IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.ОтчетОПродажах
    {
        
        // *** Start programmer edit section *** (ЗаказПокуп CustomMembers)

        // *** End programmer edit section *** (ЗаказПокуп CustomMembers)

        
        /// <summary>
        /// ДатаНачала.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПокуп.ДатаНачала CustomAttributes)

        // *** End programmer edit section *** (ЗаказПокуп.ДатаНачала CustomAttributes)
        public override System.DateTime ДатаНачала
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаНачала Get start)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаНачала Get start)
                System.DateTime result = base.ДатаНачала;
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаНачала Get end)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаНачала Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаНачала Set start)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаНачала Set start)
                base.ДатаНачала = value;
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаНачала Set end)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаНачала Set end)
            }
        }
        
        /// <summary>
        /// ДатаОкончания.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПокуп.ДатаОкончания CustomAttributes)

        // *** End programmer edit section *** (ЗаказПокуп.ДатаОкончания CustomAttributes)
        public override System.DateTime ДатаОкончания
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаОкончания Get start)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаОкончания Get start)
                System.DateTime result = base.ДатаОкончания;
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаОкончания Get end)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаОкончания Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаОкончания Set start)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаОкончания Set start)
                base.ДатаОкончания = value;
                // *** Start programmer edit section *** (ЗаказПокуп.ДатаОкончания Set end)

                // *** End programmer edit section *** (ЗаказПокуп.ДатаОкончания Set end)
            }
        }
        
        /// <summary>
        /// СостОплат.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПокуп.СостОплат CustomAttributes)

        // *** End programmer edit section *** (ЗаказПокуп.СостОплат CustomAttributes)
        public override IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.СостОплаты СостОплат
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПокуп.СостОплат Get start)

                // *** End programmer edit section *** (ЗаказПокуп.СостОплат Get start)
                IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.СостОплаты result = base.СостОплат;
                // *** Start programmer edit section *** (ЗаказПокуп.СостОплат Get end)

                // *** End programmer edit section *** (ЗаказПокуп.СостОплат Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПокуп.СостОплат Set start)

                // *** End programmer edit section *** (ЗаказПокуп.СостОплат Set start)
                base.СостОплат = value;
                // *** Start programmer edit section *** (ЗаказПокуп.СостОплат Set end)

                // *** End programmer edit section *** (ЗаказПокуп.СостОплат Set end)
            }
        }
        
        /// <summary>
        /// СостОтгруз.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПокуп.СостОтгруз CustomAttributes)

        // *** End programmer edit section *** (ЗаказПокуп.СостОтгруз CustomAttributes)
        public override IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.СостОгрузки СостОтгруз
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПокуп.СостОтгруз Get start)

                // *** End programmer edit section *** (ЗаказПокуп.СостОтгруз Get start)
                IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.СостОгрузки result = base.СостОтгруз;
                // *** Start programmer edit section *** (ЗаказПокуп.СостОтгруз Get end)

                // *** End programmer edit section *** (ЗаказПокуп.СостОтгруз Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПокуп.СостОтгруз Set start)

                // *** End programmer edit section *** (ЗаказПокуп.СостОтгруз Set start)
                base.СостОтгруз = value;
                // *** Start programmer edit section *** (ЗаказПокуп.СостОтгруз Set end)

                // *** End programmer edit section *** (ЗаказПокуп.СостОтгруз Set end)
            }
        }
        
        /// <summary>
        /// СумВклНДС.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПокуп.СумВклНДС CustomAttributes)

        // *** End programmer edit section *** (ЗаказПокуп.СумВклНДС CustomAttributes)
        public override int СумВклНДС
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПокуп.СумВклНДС Get start)

                // *** End programmer edit section *** (ЗаказПокуп.СумВклНДС Get start)
                int result = base.СумВклНДС;
                // *** Start programmer edit section *** (ЗаказПокуп.СумВклНДС Get end)

                // *** End programmer edit section *** (ЗаказПокуп.СумВклНДС Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПокуп.СумВклНДС Set start)

                // *** End programmer edit section *** (ЗаказПокуп.СумВклНДС Set start)
                base.СумВклНДС = value;
                // *** Start programmer edit section *** (ЗаказПокуп.СумВклНДС Set end)

                // *** End programmer edit section *** (ЗаказПокуп.СумВклНДС Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПокуп.Сумма CustomAttributes)

        // *** End programmer edit section *** (ЗаказПокуп.Сумма CustomAttributes)
        public override int Сумма
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПокуп.Сумма Get start)

                // *** End programmer edit section *** (ЗаказПокуп.Сумма Get start)
                int result = base.Сумма;
                // *** Start programmer edit section *** (ЗаказПокуп.Сумма Get end)

                // *** End programmer edit section *** (ЗаказПокуп.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПокуп.Сумма Set start)

                // *** End programmer edit section *** (ЗаказПокуп.Сумма Set start)
                base.Сумма = value;
                // *** Start programmer edit section *** (ЗаказПокуп.Сумма Set end)

                // *** End programmer edit section *** (ЗаказПокуп.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаказПокупE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказПокупE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказПокупE", typeof(IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.ЗаказПокуп));
                }
            }
            
            /// <summary>
            /// "ЗаказПокупL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказПокупL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказПокупL", typeof(IIS.FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.ЗаказПокуп));
                }
            }
        }
    }
}
