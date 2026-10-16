using RefactoringLab;
using Refactoring.part_01.src;

// --- 1. Shipping  ---
var aramexShipping = new ShippingCostCalculator(new AramexCarrier());
Console.WriteLine($"Aramex 2kg → {aramexShipping.Calculate(2)}");

var fedexShipping = new ShippingCostCalculator(new FedExCarrier());
Console.WriteLine($"FedEx 2kg  → {fedexShipping.Calculate(2)}");

// Proving the new carrier works
var bostaShipping = new ShippingCostCalculator(new BostaCarrier());
Console.WriteLine($"Bosta 2kg  → {bostaShipping.Calculate(2)}");
Console.WriteLine();

// --- 2. Order Processor  ---
var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();

// --- 3. Notifications  ---
var scheduledEmail = new Notification(new EmailChannel(), isUrgent: true, sendAt: DateTime.Today.AddHours(18));
scheduledEmail.Send("customer@example.com", "Your order ships tomorrow");

var urgentSms = new Notification(new SmsChannel(), isUrgent: true);
urgentSms.Send("+201000000000", "OTP 4821");

// Proving the new channel works
var whatsapp = new Notification(new WhatsAppChannel(), isUrgent: false);
whatsapp.Send("+201000000000", "Your package is out for delivery");