# Project Title

Rating Engine and Quote API

## Getting Started

### Dependencies

.NET 5.0 SDK: https://dotnet.microsoft.com/download/dotnet/5.0
### Installing

```git clone https://github.com/jsb8908/coterie-takehome.git ```

### Executing program

```cd coterie-takehome\RatingEngineQuoteAPI```

```dotent run```

### Testing program

To test, you can either:

1. Import Postman collection from: https://github.com/jsb8908/coterie-takehome/blob/main/RatingEngineQuoteAPI/RatingEnginePostmanAPI.postman_collection.json
2. Point browser to url: https://localhost:5001/swagger/index.html

### Next Steps
1. MVP Needs - Bare minimum before Production
    - Auth - Add authentication, consider Authorization at this time. Use bearer tokens, create users, etc..
    - Data Store - Implement a real data store. Use Azure SQL DB or similar cloud provider/store
    - Validations / Error Messages - Add proper validation on Controller endpoints. Create proper Exception handling, possibly introduce middleware, at a minimum try/catch on every Controller endpoint. Use consistent Error responses.
    - Tests - Add Unit tests and/or e2e.
    - Build - Add a build file for current pipeline infrastructure / environments. 

2. Immediate Priorities - First features to work on
    - Expand Controller endpoints to include all CRUD. API should have the ability to Add/Edit/Delete data in data store. 
    - Add a UI - include admin functionality
    - Assess any performance issues and scalability (beyond what was done for initial mvp)

3. Roadmap - Nice to haves down the road
    - Re-write as a Serverless endpoint. 
    - Consider first class integrations for partners. Logic Apps or similar.