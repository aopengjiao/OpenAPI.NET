﻿//---------------------------------------------------------------------
// <copyright file="OpenApiSchema.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.OpenApi
{
    /// <summary>
    /// Schema Object.
    /// </summary>
    public class OpenApiSchema : IReference
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public string Description { get; set; }
        public decimal? Maximum { get; set; }
        public bool ExclusiveMaximum { get; set; } = false;
        public decimal? Minimum { get; set; }
        public bool ExclusiveMinimum { get; set; } = false;
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public string Pattern { get; set; }
        public decimal MultipleOf { get; set; }
        public string Default { get; set; }
        public bool ReadOnly { get; set; }
        public bool WriteOnly { get; set; }
        public List<OpenApiSchema> AllOf { get; set; }
        public List<OpenApiSchema> OneOf { get; set; }
        public List<OpenApiSchema> AnyOf { get; set; }
        public OpenApiSchema Not { get; set; }
        public string[] Required { get; set; }
        public OpenApiSchema Items { get; set; }
        public int? MaxItems { get; set; }
        public int? MinItems { get; set; }
        public bool UniqueItems { get; set; }
        public Dictionary<string,OpenApiSchema> Properties { get; set; }
        public int? MaxProperties { get; set; }
        public int? MinProperties { get; set; }
        public bool AdditionalPropertiesAllowed { get; set; }
        public OpenApiSchema AdditionalProperties { get; set; }

        public string Example { get; set; }
        public List<string> Enum { get; set; } = new List<string>();
        public bool Nullable { get; set; }
        public OpenApiExternalDocs ExternalDocs { get; set; }
        public bool Deprecated { get; set; }

        public Dictionary<string, IOpenApiExtension> Extensions { get; set; } = new Dictionary<string, IOpenApiExtension>();

        public OpenApiReference Pointer
        {
            get;
            set;
        }
    }
}