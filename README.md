Just a simple school management project in 2 containers. To run this locally, just add the data layer in docker:
      docker run --name postgresql-container -p 5432:5432 -e POSTGRES_PASSWORD=root -d postgres
      
