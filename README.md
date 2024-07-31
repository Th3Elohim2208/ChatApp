
# ChatApp

Una aplicación de chat simple creada con C# y .NET 8 usando sockets.

## Descripción

ChatApp es una aplicación de mensajería instantánea similar a WhatsApp. Cada instancia de la aplicación es un cliente de chat diferente que puede comunicarse con otros clientes mediante sockets UDP.

## Características

- Envío y recepción de mensajes en tiempo real.
- Cada cliente se identifica por un número de puerto.
- Interfaz gráfica simple con Windows Forms.

## Requisitos

- .NET 8 SDK
- Visual Studio o Visual Studio Code

## Instalación

1. Clona este repositorio:

    ```sh
    git clone https://github.com/tu-usuario/ChatApp.git
    cd ChatApp
    ```

2. Abre el proyecto con Visual Studio o Visual Studio Code.

## Ejecución

Para ejecutar varias instancias de la aplicación y simular diferentes clientes:

1. Abre una terminal y navega al directorio del proyecto.
2. Ejecuta la aplicación con un puerto específico:

    ```sh
    dotnet run --project ChatApp -- 11000
    ```

3. Abre otra terminal y ejecuta la aplicación con un puerto diferente:

    ```sh
    dotnet run --project ChatApp -- 11001
    ```

Repite el paso 3 tantas veces como necesites, cambiando el número de puerto cada vez.

## Uso

1. En la ventana de la aplicación, ingresa el número de puerto del destinatario en el campo "Puerto".
2. Escribe tu mensaje en el campo "Mensaje".
3. Haz clic en "Enviar" para enviar el mensaje.

Los mensajes recibidos se mostrarán en la lista de mensajes.

## Contribuciones

Las contribuciones son bienvenidas. Siéntete libre de abrir un issue o enviar un pull request.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT.
