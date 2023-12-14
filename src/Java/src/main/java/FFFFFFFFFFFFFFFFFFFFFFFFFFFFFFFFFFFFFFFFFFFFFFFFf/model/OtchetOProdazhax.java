package FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFf.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;
import java.util.Date;
import java.util.List;

/**
 * Entity implementation class for Entity: ОтчетОПродажах
 */
@Entity(name = "IISFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFfОтчетОПродажах")
@Table(schema = "public", name = "ОтчетОПродажах")
public class OtchetOProdazhax {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "ДатаОкончания")
    private Date датаокончания;

    @Column(name = "ДатаНачала")
    private Date датаначала;

    @Column(name = "СумВклНДС")
    private Integer сумвклндс;

    @Column(name = "СостОтгруз")
    private String состотгруз;

    @Column(name = "СостОплат")
    private String состоплат;

    @Column(name = "Сумма")
    private Integer сумма;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Organizacii")
    @Convert("Organizacii")
    @Column(name = "Организации", length = 16, unique = true, nullable = false)
    private UUID _organizaciiid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Organizacii", insertable = false, updatable = false)
    private Organizacii organizacii;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Kontragenty")
    @Convert("Kontragenty")
    @Column(name = "Контрагенты", length = 16, unique = true, nullable = false)
    private UUID _kontragentyid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Kontragenty", insertable = false, updatable = false)
    private Kontragenty kontragenty;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Sklady")
    @Convert("Sklady")
    @Column(name = "Склады", length = 16, unique = true, nullable = false)
    private UUID _skladyid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Sklady", insertable = false, updatable = false)
    private Sklady sklady;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Podrazeleniya")
    @Convert("Podrazeleniya")
    @Column(name = "Подразеления", length = 16, unique = true, nullable = false)
    private UUID _podrazeleniyaid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Podrazeleniya", insertable = false, updatable = false)
    private Podrazeleniya podrazeleniya;

    @OneToMany(mappedBy = "otchetoprodazhax", fetch = FetchType.LAZY, cascade = CascadeType.REMOVE)
    private List<TCHTovarIUslug> tchtovariuslugs;


    public OtchetOProdazhax() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public Date getДатаОкончания() {
      return датаокончания;
    }

    public void setДатаОкончания(Date датаокончания) {
      this.датаокончания = датаокончания;
    }

    public Date getДатаНачала() {
      return датаначала;
    }

    public void setДатаНачала(Date датаначала) {
      this.датаначала = датаначала;
    }

    public Integer getСумВклНДС() {
      return сумвклндс;
    }

    public void setСумВклНДС(Integer сумвклндс) {
      this.сумвклндс = сумвклндс;
    }

    public String getСостОтгруз() {
      return состотгруз;
    }

    public void setСостОтгруз(String состотгруз) {
      this.состотгруз = состотгруз;
    }

    public String getСостОплат() {
      return состоплат;
    }

    public void setСостОплат(String состоплат) {
      this.состоплат = состоплат;
    }

    public Integer getСумма() {
      return сумма;
    }

    public void setСумма(Integer сумма) {
      this.сумма = сумма;
    }


}