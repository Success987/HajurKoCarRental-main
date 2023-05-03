namespace HajurKoCarRental.App.Routing;

internal class Routes
{
    /// <summary>
    /// `POST /api/auth/register` - Register a new customer account.
    /// </summary>
    internal const string RegisterRoute = "/auth/register";
    /// <summary>
    /// `POST /api/auth/login` - Log in to an existing customer account.
    /// </summary>
    internal const string LoginRoute = "/auth/login";
    /// <summary>
    /// `POST /api/auth/login` - Log out from a logged in customer account.
    /// </summary>
    internal const string LogoutRoute = "/auth/logout";
    /// <summary>
    /// `POST /api/auth/forgot-password` - Send a password reset link to the customer's email address.
    /// </summary>
    internal const string ForgotPasswordRoute = "/auth/reset-password";
    /// <summary>
    /// `POST /api/auth/reset-password` - Reset the customer's password.
    /// </summary>
    const string ResetPasswordRoute = "/auth/reset-password";
    /// <summary>
    /// `POST /api/documents/upload` - Upload a customer's driving license or citizenship paper.
    /// </summary>
    const string DocumentsUploadRoute = "/documents/upload";
    /// <summary>
    /// `GET /api/documents/download` - Download a customer's previously uploaded documents.
    /// </summary>
    const string DocumentsDownloadRoute = "/documents/download";
    /// <summary>
    /// `POST /api/cars` - Add a new car to the rental inventory.
    /// `GET /api/cars` - Get a list of all available cars for rent.
    /// </summary>
    const string CarsRoute = "/cars";
    /// <summary>
    /// `PUT /api/cars/{id}` - Update an existing car's information.
    /// `DELETE /api/cars/{id}` - Remove a car from the rental inventory.
    /// `GET /api/cars/{id}` - Get details about a specific car.
    /// </summary>
    const string CarRoute = "/cars/{id}";
    /// <summary>
    /// `POST /api/rentals` - Initiate a rental request.
    /// `GET /api/rentals` - Get a list of all rental requests.
    /// </summary>
    const string RentalsRoute = "/rentals";
    /// <summary>
    /// `GET /api/rentals/{id}` - Get details about a specific rental request.
    /// `PUT /api/rentals/{id}` - Update the status of a rental request.
    /// `DELETE /api/rentals/{id}` - Cancel a rental request.
    /// </summary>
    const string RentalRoute = "/rentals/{id}";
    /// <summary>
    /// `POST /api/damages` - Submit a damage request for a rented car.
    /// `GET /api/damages` - Get a list of all damage requests.
    /// </summary>
    const string DamagesRoute = "/damages";
    /// <summary>
    /// `GET /api/damages/{id}` - Get details about a specific damage request.
    /// `PUT /api/damages/{id}` - Update the status of a damage request.
    /// </summary>
    const string DamageRoute = "/damages/{id}";
    /// <summary>
    /// `POST /api/payments` - Submit a payment for a rental or repair bill.
    /// `GET /api/payments` - Get a list of all payments.
    /// </summary>
    const string PaymentsRoute = "/payments";
    /// <summary>
    /// `GET /api/payments/{id}` - Get details about a specific payment.
    /// </summary>
    const string PaymentRoute = "/payments/{id}";
    /// <summary>
    /// `POST /api/offers` - Create a new special offer for customers.
    /// `GET /api/offers` - Get a list of all current special offers.
    /// </summary>
    const string OffersRoute = "/offers";
    /// <summary>
    /// `GET /api/offers/{id}` - Get details about a specific special offer.
    /// </summary>
    const string OfferRoute = "/offers/{id}";
    /// <summary>
    /// `GET /api/customers` - Get a list of all registered customers.
    /// </summary>
    const string CustomersRoute = "/customers";
    /// <summary>
    /// `GET /api/customers/{id}` - Get details about a specific customer.
    /// `PUT /api/customers/{id}` - Update a customer's information.
    /// `DELETE /api/customers/{id}` - Remove a customer account.
    /// </summary>
    const string CustomerRoute = "/customers/{id}";
}
