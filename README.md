# AzureAD-example

## Disclaimer
This example is not production ready, and is to be considered as a getting started guide for Using AzureAD with BFF pattern.
Before using this example in a production environment it is very important to add a Content Security Policy for XSS protection, and anti forgery token for Cross-Site Request Forgery protection.
The handling of the authentication state in the frontend is in the instance very simple. How this needs to be handled depends on your frameworks and application requirements.

## To start using example
- Complete app registration in AzureAD.
- Fill in missing values in appsettings.json.

## About
This example follows the BFF pattern where no tokens are stored in the frontend. A cookie session is created between the frontend and the backend.

Note that OIDC flow is handled by the backend and triggered through the AccountController. Note also the UserController which provides authentication state for the frontend.