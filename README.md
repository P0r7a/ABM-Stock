# 📋 Sistema de Gestión Personalizada - ABM en Windows Forms (C#)

Este proyecto es una aplicación de escritorio desarrollada en **C# con Windows Forms**, como parte de mi proyecto final para la **Tecnicatura en Programación**. Su objetivo principal es ofrecer un sistema **ABM (Alta, Baja, Modificación)** personalizado, con múltiples categorías y un sistema de gestión de usuarios.

## 🎯 Funcionalidades

- 🔐 Registro y login de usuarios con validación y control de acceso
- 📁 Gestión de diferentes categorías de datos (adaptable a múltiples usos)
- ✅ Funciones de ABM completas: agregar, editar, eliminar y buscar registros
- 🔎 Filtros avanzados para búsquedas por categoría
- 💾 Uso de base de datos local en formato Microsoft Access (`.accdb`)
- 🖥️ Interfaz amigable desarrollada con Windows Forms

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C# (.NET Framework)
- **Interfaz Gráfica:** Windows Forms
- **Base de Datos:** Microsoft Access
- **IDE:** Visual Studio

## 🚀 Cómo ejecutar el proyecto

1. Clonar este repositorio:

   ```bash
   git clone https://github.com/tu-usuario/tu-repo.git
   ```

2. Abrir la solución `Proyecto.sln` con **Visual Studio**.

3. Verificar que el archivo de base de datos `Proyecto.accdb` esté ubicado en la carpeta `Resources`.

4. Compilar y ejecutar presionando `F5`.

## 📁 Estructura del Proyecto

```
Proyecto/
├── Resources/
│   └── Proyecto.accdb        # Base de datos Access
├── frmLogin.cs               # Formulario de autenticación
├── frmMain.cs                # Pantalla principal y navegación
├── frmABM*.cs                # Formularios por categoría para ABM
├── Program.cs                # Punto de entrada de la aplicación
└── Proyecto.sln              # Solución de Visual Studio
```

## 👨‍💻 Autor

**Facundo Aguiar**  
Técnico en Programación  
📧 [Tu correo (opcional)]  
🔗 [LinkedIn o portfolio (opcional)]

---

## 📌 Notas

- Este proyecto fue desarrollado con fines educativos y puede ser adaptado a distintos contextos (gestión de productos, usuarios, inventarios, etc.).
- La estructura está pensada para ser fácilmente escalable.

## ⭐ Licencia

Este proyecto se encuentra bajo la licencia **MIT**, por lo que podés usarlo y modificarlo libremente con atribución.
