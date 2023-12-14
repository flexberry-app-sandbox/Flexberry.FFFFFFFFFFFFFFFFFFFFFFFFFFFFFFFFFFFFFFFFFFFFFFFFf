import { Serializer as ЗаказПокупSerializer } from
  '../mixins/regenerated/serializers/i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-заказ-покуп';
import ОтчетОПродажахSerializer from './i-i-s-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-f-ff-отчет-о-продажах';

export default ОтчетОПродажахSerializer.extend(ЗаказПокупSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
