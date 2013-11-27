/*
   Copyright 2012 Michael Edwards
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 
*/ 
//-CRE-
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;

namespace Glass.Mapper.Umb.Web.Ui
{
    /// <summary>
    /// GlassViewPage
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GlassViewPage<T> : UmbracoViewPage<T> where T : class
    {
        private readonly IUmbracoService _umbracoService;


        /// <summary>
        /// Initializes a new instance of the <see cref="GlassViewPage{T}"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public GlassViewPage(IUmbracoService service)
        {
            _umbracoService = service;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlassViewPage{T}"/> class.
        /// </summary>
        public GlassViewPage()
            : this(new UmbracoService(new ContentService()))
        {
        }

        /// <summary>
        /// Gets the umbraco service.
        /// </summary>
        /// <value>
        /// The umbraco service.
        /// </value>
        public IUmbracoService UmbracoService
        {
            get { return _umbracoService; }
        }

        /// <summary>
        /// Executes the server code in the current web page that is marked using Razor syntax.
        /// </summary>
        public override void Execute()
        {
        }
    }
}
