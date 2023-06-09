﻿namespace ChainOfResponsibilityExample
{
    class Client
    {
        void Main()
        {
            // Первый обработчик
            Handler handlerOne = new HandlerOne();
            
            // Второй обработчик
            Handler handlerTwo = new HandlerTwo();
            
            // Передача запроса по цепочке и обработка
            handlerOne.Successor = handlerTwo;
            handlerOne.HandleRequest(2);
        }
    }
    
    /// <summary>
    /// Базовый интерфейс обработчика
    /// </summary>
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }
 
    /// <summary>
    /// Реализаци первого обработчика
    /// </summary>
    class HandlerOne : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition==1)
            {
                // Завершение обработки при выполненном условии
            }
            else if (Successor != null)
            {
                // Условие не выполнено - передаем дальше по цепи
                Successor.HandleRequest(condition);
            }
        }
    }
 
    /// <summary>
    /// Реализаци второго обработчика
    /// </summary>
    class HandlerTwo : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition==2)
            {
                // Завершение обработки при выполненном условии
            }
            else if (Successor != null)
            {
                // Условие не выполнено - передаем дальше по цепи
                Successor.HandleRequest(condition);
            }
        }
    }
}