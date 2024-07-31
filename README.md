
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
- Visual Studio 

## Instalación

1. Clona este repositorio:

    ```sh
    git clone https://github.com/Th3Elohim2208/ChatApp.git
    cd ChatApp
    ```

2. Abre el proyecto con Visual Studio o Visual Studio Code.

## Ejecución

Para ejecutar varias instancias de la aplicación y simular diferentes clientes:

1. Abre una terminal y navega al directorio del proyecto.
2. Ejecuta la aplicación con un puerto específico:

    ```sh
    dotnet run --nombre-del-proyecto-- 11000
    ```

3. Abre otra terminal y ejecuta la aplicación con un puerto diferente:

    ```sh
    dotnet run --nombre-del-proyecto -- 11001
    ```

Repite el paso 3 tantas veces como necesites, cambiando el número de puerto cada vez.


 En caso de no poder ejecutar la aplicacion desde la terminal:
 
 1. Haz clic derecho en el nombre de tu proyecto en el Explorador de Soluciones y selecciona Propiedades.
 2. Haz clic en Depuración en el menú de la izquierda.
 3. En la sección Argumentos de línea de comandos, escribe el número del puerto que deseas usar para la primera instancia. Por ejemplo, escribe 11000.
 4. Con estos ajustes, inicia la aplicación haciendo clic en Depurar > Iniciar sin depuración o presionando Ctrl + F5. Esto lanzará la primera instancia con el puerto 11000.
 5. Vuelve a las propiedades del proyecto y cambia el número del puerto en los Argumentos de línea de comandos a 11001.
 6. Nuevamente, haz clic en Depurar > Iniciar sin depuración o presiona Ctrl + F5. Esto lanzará la segunda instancia con el puerto 11001.

## Uso

1. En la ventana de la aplicación, ingresa el número de puerto del destinatario en el campo "Puerto".
2. Escribe tu mensaje en el campo "Mensaje".
3. Haz clic en "Enviar" para enviar el mensaje.

Los mensajes recibidos se mostrarán en la lista de mensajes.
