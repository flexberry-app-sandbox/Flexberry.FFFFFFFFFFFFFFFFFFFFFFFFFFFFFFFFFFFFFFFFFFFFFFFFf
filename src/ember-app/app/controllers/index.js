import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.a.caption'),
          title: i18n.t('forms.application.sitemap.a.title'),
          children: [{
            link: null,
            caption: i18n.t('forms.application.sitemap.a.отчеты.caption'),
            title: i18n.t('forms.application.sitemap.a.отчеты.title'),
            children: [{
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-отчет-о-продажах-l',
              caption: i18n.t('forms.application.sitemap.a.отчеты.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-отчет-о-продажах-l.caption'),
              title: i18n.t('forms.application.sitemap.a.отчеты.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-отчет-о-продажах-l.title'),
              icon: 'file',
              children: null
            }, {
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-остат-на-склад-l',
              caption: i18n.t('forms.application.sitemap.a.отчеты.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-остат-на-склад-l.caption'),
              title: i18n.t('forms.application.sitemap.a.отчеты.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-остат-на-склад-l.title'),
              icon: 'archive',
              children: null
            }]
          }, {
            link: null,
            caption: i18n.t('forms.application.sitemap.a.справочники.caption'),
            title: i18n.t('forms.application.sitemap.a.справочники.title'),
            children: [{
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-организации-l',
              caption: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-организации-l.caption'),
              title: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-организации-l.title'),
              children: null
            }, {
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-склады-l',
              caption: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-склады-l.caption'),
              title: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-склады-l.title'),
              icon: 'folder',
              children: null
            }, {
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-номенклатуры-l',
              caption: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-номенклатуры-l.caption'),
              title: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-номенклатуры-l.title'),
              icon: 'chart line',
              children: null
            }, {
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-ед-измер-l',
              caption: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-ед-измер-l.caption'),
              title: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-ед-измер-l.title'),
              icon: 'chart line',
              children: null
            }, {
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-подразеления-l',
              caption: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-подразеления-l.caption'),
              title: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-подразеления-l.title'),
              icon: 'edit',
              children: null
            }, {
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-контрагенты-l',
              caption: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-контрагенты-l.caption'),
              title: i18n.t('forms.application.sitemap.a.справочники.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-контрагенты-l.title'),
              icon: 'edit',
              children: null
            }]
          }, {
            link: null,
            caption: i18n.t('forms.application.sitemap.a.договора.caption'),
            title: i18n.t('forms.application.sitemap.a.договора.title'),
            children: [{
              link: 'i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-заказ-покуп-l',
              caption: i18n.t('forms.application.sitemap.a.договора.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-заказ-покуп-l.caption'),
              title: i18n.t('forms.application.sitemap.a.договора.i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-заказ-покуп-l.title'),
              icon: 'list',
              children: null
            }]
          }]
        }
      ]
    };
  }),
})