# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Juan",
    "lastName": "Wick",
    "email": "juan.wick@example.com",
    "password": "SafePass123!"
}
```
#### Register Response

```js
200 OK
```

```json
{
  "id": "df3e4b2c-1a2b-4c3d-9e5f-6a7b8c9d0e1f",
  "firstName": "Juan",
  "lastName": "Wick",
  "email": "juan.wick@example.com",
  "token": "eyJhbI...6IkpXVCJ9"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
  "email": "juan.wick@example.com",
  "password": "SafePass123!"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "df3e4b2c-1a2b-4c3d-9e5f-6a7b8c9d0e1f",
    "firstName": "Juan",
    "lastName": "Wick",
    "email": "juan.wick@example.com",
    "token": "eyJhbI...6IkpXVCJ9"
}
```