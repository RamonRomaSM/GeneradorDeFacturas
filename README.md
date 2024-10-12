# Generador de Facturas
Este es un generador de facturas estándar para cualquier tipo de negocio
(https://administracionelectronica.gob.es/ctt/face/descargas)

### Como funciona la factura:
  + 1 cliente
  + N conceptos
  + N importes
  + El IVA se aplica sobre el total de la suma de los importes
  + IRPF:
      + El Cliente y/ o el Facturante pueden ser personas fisicas o juridicas:       
          +   Cliente fis Fact jur:  no aplica
          +   Cliente juridica Fact fis: si aplica
          +   Cliente fis Fact fis: no
          +   Cliente jur Fact jur: no


### Datos:
 + Nombre Facturante
 + Domicilio Facturante
 + C postal (opcional)
 + Id factura 
 + Nombre del Cliente
 + Domicilio Cliente
 + Documento
 + Conceptos
 + Importes
 + IVA sobre el total
 + IRPF de tenerlo
 + TOTAL final
 + Fecha
 + Documento del Facturante (receptor)
 
### Extra:
 + Times new roman como fuente
 + Que la fecha aparezca placeholder de hoy, pero no tiene por que ser hoy
 + Que la fecha y el importe aparezcan con palabras
 + Pushear copia sqlite a google drive

### Id factura:
+ aaaammdd_n (n es un numero consecutivo, se reinicia por dia)

### Casos de uso
+  Generar facturas
+  Visualizar fac


### BDD:
  + Facturante
  + Cliente
  + Datos_Factura
      +  Nombre Facturante
      +  Domicilio Facturante
      +  C postal (opcional)
      +  Conceptos
      +  SiFisica
  + Facturas_Generadas



     
