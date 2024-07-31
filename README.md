# BillGenerator
Este es un generador de facturas estándar para cualquier tipo de negocio


Como funciona la factura:
  + 1 cliente
  + N conceptos
  + N importes
  + El IVA se aplica sobre el total de la suma de los importes
  + De ser Juridica, el IRPF se aplica (y aplica restando) sobre el total con el iva aplicado

Datos:
 + Nombre del Cliente
 + Domicilio pagador
 + Documento
 + Conceptos
 + Importes
 + IVA sobre el total
 + IRPF de tenerlo
 + TOTAL final
 + Fecha
 + Documento del Facturante (receptor)
 
Extra:
 + Times new roman como fuente
 + Que la fecha aparezca placeholder de hoy, pero no tiene por que ser hoy
 + Que la fecha y el importe aparezcan con palabras


BDD:
  +  
