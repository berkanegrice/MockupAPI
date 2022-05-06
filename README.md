# MockupAPI

MockupAPI aims to eliminate the time required for API development during the project development process. 
It provides parallel development opportunity for different teams using the same API.

## Behaviours of API

This API has a two parameters, they are; 
  - **output** : This is a JSON-formatted string used to determine the value returned from the method.
  - **httpReturnCode** : This is an entry for decide which the HTTP response code to be returned.

## Input structure

The input should be given in the structure below.
```json
{
  "output": "string",
  "httpReturnCode": 0
}
```

## Prequisites
 - ASP.NET Core 6 (or later)

### Usage
- Call a POST Method
```console
    curl -X 'POST' \
      '<api-url>/api/Method' \
      -H 'accept: */*' \
      -H 'Content-Type: application/json' \
      -d '{
        "output": "string",
        "httpReturnCode": 200
      }'
```
- Call a GET Method
```console
    curl -X 'GET' \
      '<api-url>/api/Method?Output=200' \
      -H 'accept: */*'
```
