# NWN.Framework.Lite.Template

## Docker Installation

Assuming you have Docker installed correctly then inside the `Docker` directory Copy/Move `docker-compose.yml` to your NWN Installation folder. For most Windows users the installation path will be something like this.

```sh
C:\Users\ProfileName\Documents\Neverwinter Nights
```

Next, create a folder in the same directory called `dotnet`.

## How To Launch

Build your project in your IDE. When finished go to your project folder and copy all files in `bin -> Debug -> net5.0` and place them in the `dotnet` directory. From there `cd` to your `docker-compose.yml` and type

```sh
docker-compose up
```

and nwserver will spin up.
