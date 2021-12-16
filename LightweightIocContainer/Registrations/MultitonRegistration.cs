﻿// Author: Gockner, Simon
// Created: 2019-06-07
// Copyright(c) 2019 SimonG. All Rights Reserved.

using System;
using LightweightIocContainer.Interfaces;
using LightweightIocContainer.Interfaces.Registrations;

namespace LightweightIocContainer.Registrations
{
    /// <summary>
    /// The registration that is used to register a multiton
    /// </summary>
    /// <typeparam name="TInterface">The registered interface</typeparam>
    /// <typeparam name="TImplementation">The registered implementation</typeparam>
    internal class MultitonRegistration<TInterface, TImplementation> : TypedRegistration<TInterface, TImplementation>, IMultitonRegistration<TInterface, TImplementation> where TImplementation : TInterface
    {
        /// <summary>
        /// The registration that is used to register a multiton
        /// </summary>
        /// <param name="interfaceType">The <see cref="Type"/> of the Interface</param>
        /// <param name="implementationType">The <see cref="Type"/> of the Implementation</param>
        /// <param name="scope">The <see cref="Type"/> of the Multiton Scope</param>
        /// <param name="container">The current instance of the <see cref="IIocContainer"/></param>
        public MultitonRegistration(Type interfaceType, Type implementationType, Type scope, IocContainer container)
            : base(interfaceType, implementationType, Lifestyle.Multiton, container) =>
            Scope = scope;

        /// <summary>
        /// The <see cref="Type"/> of the multiton scope
        /// </summary>
        public Type Scope { get; }
    }
}