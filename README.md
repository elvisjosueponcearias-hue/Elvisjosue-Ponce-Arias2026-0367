Elvisjosue-Ponce-Arias (2026-0367).
Aplicación de escritorio en C# (Windows Forms) para RentaCar Express que permite registrar alquileres de vehículos, sumar extras (seguro completo y GPS), acumular subtotales y calcular automáticamente el descuento corporativo (15 %), envío a domicilio (RD$500), ITBIS (18 %) y el total a pagar.

 Datos de entrada

Cliente: Nombre del cliente (`txtCliente`).
Cliente corporativo: Casilla de verificación (`chkCorporativo`).
Fecha de salida:  Fecha seleccionada (`dtpSalida`).  
Vehículo: Modelo o tipo de vehículo (`txtVehiculo`).  
Tarifa: Tarifa diaria base en pesos dominicanos (`txtTarifa`).  
Días: Cantidad de días de alquiler (`nudDias`).  
Seguro: Básico o Completo +RD$300/día (`rbtBasico`, `rbtCompleto`). 
Entrega: En sucursal o Domicilio +RD$500 (`rbtSucursal`, `rbtDomicilio`).
GPS: Adicional de +RD$100/día (`chkGps`). 

 Proceso

1. Tarifa diaria final: Tarifa base + RD$300 (si se selecciona seguro completo) + RD$100 (si se marca GPS). 
2. Total por vehículo: Tarifa diaria final × cantidad de días.  
3. Subtotal: Suma de los totales de todos los vehículos agregados a la lista.  
4. Descuento: 15 % del subtotal si está marcado como cliente corporativo; de lo contrario, RD$0.00.  
5. Domicilio: RD$500.00 si se selecciona entrega a domicilio; RD$0.00 si es en sucursal.  
6. Base imponible: Subtotal - Descuento + Domicilio.  
7. ITBIS (18 %): 18 % aplicado sobre la base imponible.
8. Total a pagar: Base imponible + ITBIS.  

 Salida
 
Lista de vehículos (lstAlquileres): Muestra cada alquiler en columnas alineadas con encabezado (Días, Vehículo, Tarifa, Total).   
Desglose de montos: Etiquetas formateadas en moneda (RD$ 0.00) para Subtotal, Descuento, Domicilio, ITBIS (18 %) y TOTAL A PAGAR.
<img width="1146" height="571" alt="Captura de pantalla 2026-11-19 232351" src="https://github.com/user-attachments/assets/65d059e1-6603-4fed-8210-072510626535" />

https://github.com/elvisjosueponcearias-hue?tab=repositories
