#  Subscription Platform System

A console-based subscription management system developed in C#.

This project simulates a real subscription platform (like Netflix or SaaS systems) and was built to practice strong object-oriented programming concepts and business rule validation.

---

##  Features

- Create Basic, Premium and Corporate subscriptions
- Activate and deactivate subscriptions
- Prevent duplicate subscription codes
- Calculate monthly revenue considering only active subscriptions
- Strong validation rules
- Polymorphism without type checking

---

##  OOP Concepts Applied

- Inheritance
- Polymorphism
- Encapsulation
- Virtual methods and override
- Business rule validation
- Collection management with List<T>

---

##  Project Structure

Assinatura (Base Class)
 ├── AssinaturaBasica
 ├── AssinaturaPremium
 ├── AssinaturaCorporativa

Plataforma (Management Layer)
Program (Console Menu)

---

##  Business Rules

- Subscription code and client name cannot be empty
- Subscriptions start as active
- Cannot deactivate an already inactive subscription
- Cannot reactivate an already active subscription
- Revenue calculation only includes active subscriptions
- Corporate subscriptions must have at least one user

---

##  Technologies

- C#
- .NET
- Console Application

---

##  Purpose

This project focuses on building a clean and extensible architecture using object-oriented principles and real-world business logic simulation.
