﻿// See https://aka.ms/new-console-template for more information

using Decorator_DesignPattern;
using System.Net;

ConcreteComponent concreteComponent = new ConcreteComponent();
//concreteComponent.Operation();
ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent);
concreteDecorator.Operation();

ConcereteComponent2 concereteComponent2 = new ConcereteComponent2();

ConcreteDecorator2 concreteDecorator2 = new ConcreteDecorator2(concereteComponent2);
concreteDecorator2.Operation01();
concreteDecorator2.Operation02();

SendEmail sendEmail = new SendEmail();
SendEmaiDecorator sendEmaiDecorator = new SendEmaiDecorator(sendEmail);
sendEmaiDecorator.Send();

WebClient webClient = new WebClient();
WebClientDecorator webClientDecorator = new WebClientDecorator(webClient);
Console.WriteLine( webClientDecorator.DownloadString("https://www.google.com"));


Console.ReadLine();
