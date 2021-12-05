# AspnetMicroservices
Simple asp.net core microservices

# Catalog MongoDb 
    Docker command : 
        docker exec -it mongo.db /bin/bash

    Connect MongoDb :
        mongo -u mongoadmin -p secret 

    Create collection:
        use CatalogDb
        db.createCollection('Products');

        db.Products.insertMany(
			[
			    {
			        "Name": "Asus Laptop",
			        "Category": "Computers",
			        "Summary": "Summary",
			        "Description": "Description",
			        "ImageFile": "ImageFile",
			        "Price": 54.93
			    },
			    {
			        "Name": "HP Laptop",
			        "Category": "Computers",
			        "Summary": "Summary",
			        "Description": "Description",
			        "ImageFile": "ImageFile",
			        "Price": 88.93
			    }
			])
            
            
        db.Products.find({}).pretty()
        db.Products.remove({})

        show databases
        show collections
        db.Products.find({}).pretty()

        #CatalogAPI List
        Method      URL
        -----       ----------------------------
        GET         api/v1/Catalog
        GET         api/v1/Catalog/{id}
        GET         api/v1/Catalog/GetProductByCategory/{category}
        POST        api/v1/Catalog
        PUT         api/v1/Catalog
        DELETE      api/v1/Catalog/{id}

# Basket Redis API
         docker pull redis
         docker run -d -p 6379:6379 --name aspnetrun-redis redis
         docker exec -it aspnetrun-redis /bin/bash

         Method      URL
        -----       ----------------------------
        GET         api/v1/Basket
        POST        api/v1/Basket
        POST        api/v1/Basket/Checkout
        DELETE      api/v1/Basket/{userName}

    Portainer tool :
        http://localhost:9000 ( user : admin /pass: Admin@123$)
# Discount Postgresql API
    Install postgres and dpage/pgadmin4 docker 
    docker-compose.override.yml file EXAMPLE

        discountdb:
        container_name: discountdb
        environment: 
        - POSTGRES_USER=admin
        - POSTGRES_PASSWORD=Abc12345
        - POSTGRES_DB=DiscountDb
        restart: always
        ports:
        - "5432:5432"
        volumes:
        - postgres_data:/var/lib/postgresql/data/
    
    pgadmin:
        container_name: pgadmin
        environment:
        - PGADMIN_DEFAULT_EMAIL=admin@aspnetrun.com
        - PGADMIN_DEFAULT_PASSWORD=Abc12345
        restart: always
        ports:
        - "5050:80"
        volumes:
        - pgadmin_data:/root/.pgadmin

    Admin login page : http://localhost:5050/

    Init script :
        Create table script : 

        CREATE TABLE Coupon(
            ID SERIAL PRIMARY KEY NOT NULL,
            ProductName VARCHAR(24) NOT NULL,
            Description TEXT,
            Amount INT
        );


    Insert Discount Data

        INSERT INTO Coupon (ProductName, Description, Amount) VALUES ('IPhone X', 'IPhone Discount', 150);

        INSERT INTO Coupon (ProductName, Description, Amount) VALUES ('Samsung 10', 'Samsung Discount', 100);




# Run docker compose file 
     docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d
     docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down