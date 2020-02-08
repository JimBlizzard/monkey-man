# Monkey-Man

[X] 1. create models

[ ] 2. connect to a db (mongo?, mysql)

[ ] 3. define APIs

--------

### API

    UserCtrl
      GET - returns a list of user(s) based on search criteria
        - by name
        - by category
        - by subcategory
        - by location
        - by role
        - by subcategory + skillLevel
      PUT - creates a user
      POST - updates a new user
      DELETE - deletes a user by name (might want to change it to id (uuid??))
    
    CategoryCtrl
      GET - returns a list of all categories
        - by category
      PUT - (admin lvl) creates a new category

    SubCategoryCtrl
      GET - returns the sub category
-------

### Model structure

```json
// USER model
{
  name: "jimmy",
  role: 0,  // enum for role type
  location: "USA",
  categories: [
    {
      name: "Azure/AI",
      categoryStrength: 2,
      subCategory: [
        {
          name: "foo",
          skillLevel: 2
        }
      ]
    },
    ...
  ]
}
```
