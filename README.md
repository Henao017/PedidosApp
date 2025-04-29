PedidosApp es una aplicación de escritorio desarrollada en C# con Windows Forms para gestionar 
pedidos en una tienda virtual. El sistema está diseñado aplicando principios de programación orientada a objetos (POO), 
patrones de diseño como Strategy, Factory Method y Singleton, 
así como los principios SOLID, con el objetivo de lograr un código limpio, escalable y fácil de mantener.

IMetodoEntrega: Interfaz que define el comportamiento común de todos los métodos de entrega.
EntregaDron, EntregaMoto, EntregaCamion: Clases que implementan IMetodoEntrega, cada una con su propia lógica de cálculo de costos y tipo de envío.
EntregaFactory: Se encarga de decidir qué estrategia de entrega utilizar según las características del pedido (peso, urgencia, tipo).
Pedido: Clase principal que representa un pedido. Almacena su información y utiliza la estrategia adecuada de entrega mediante la fábrica.
RegistroPedidos: Clase Singleton que mantiene un registro centralizado de todos los pedidos creados.

Formulario (Form1): Interfaz gráfica para que el usuario ingrese los datos del pedido, calcule el costo de entrega y visualice el resultado.
La aplicación PedidosApp utiliza C# con Windows Forms como tecnología principal para la creación de la interfaz gráfica. A nivel de diseño de software, implementa el patrón Strategy para seleccionar dinámicamente el método de entrega en función de las características del pedido, el patrón Factory Method para encapsular la lógica de creación de los distintos métodos de entrega y el patrón Singleton para garantizar una única instancia del registro de pedidos durante toda la ejecución de la aplicación. Además, se aplican los principios SOLID para asegurar un código limpio, escalable y mantenible, destacando especialmente el principio de Responsabilidad Única (SRP), que asigna una única función clara a cada clase, y el principio de Inversión de Dependencias (DIP), que permite que las clases dependan de abstracciones en lugar de implementaciones concretas, facilitando así la extensión y el desacoplamiento del sistema.

El diseño de PedidosApp promueve una arquitectura modular, flexible y orientada a buenas prácticas. Gracias a la aplicación de patrones como Strategy, Factory y Singleton, el sistema se vuelve fácil de extender y mantener

El diseño de la aplicación ofrece múltiples beneficios orientados al mantenimiento y escalabilidad del sistema. Al aplicar patrones como Strategy, Factory Method y Singleton, se logra un código modular, fácil de entender y modificar. Estos patrones permiten agregar nuevas funcionalidades, como métodos de entrega adicionales, sin alterar las clases existentes, cumpliendo con el principio de Open/Closed. Además, la separación de responsabilidades facilita la organización del código, ya que cada clase tiene un propósito específico

![image](https://github.com/user-attachments/assets/959046ee-4c51-45ca-9eff-1b2865cb83ca)
![image](https://github.com/user-attachments/assets/4881f746-1660-4a4f-b332-0af785c7ee8f)
![image](https://github.com/user-attachments/assets/d33c6152-b199-4a7c-af39-f3b009e8e8fe)
![image](https://github.com/user-attachments/assets/465df28b-22e3-4a4f-9aeb-b83d202d84c5)




