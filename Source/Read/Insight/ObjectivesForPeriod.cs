/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Linq;
using Dolittle.Queries;

namespace Read.Insight
{

    /// <summary>
    /// Represents a query for getting objectives within a period
    /// </summary>
    public class ObjectivesForPeriod : IQueryFor<Objective>
    {
#if(false)
        /// <summary>
        /// Gets or sets the start of the period
        /// </summary>
        public DateTimeOffset Start { get; set; }

        /// <summary>
        /// Gets or sets the end of the period
        /// </summary>
        public DateTimeOffset End { get; set; }
#endif        

        /// <summary>
        /// Gets the query
        /// </summary>
        public IQueryable<Objective>    Query => new[] {
            new Objective {
                Title = "Eat our own dogfood",
                KeyResults = new [] {
                    new KeyResult {
                        Title = "Continuous Improvement",
                        Epics = new[] {
                            new Epic {
                                Title = "Studio App",
                                PercentComplete = 30
                            },
                            new Epic {
                                Title = "GitHub",
                                PercentComplete = 30
                            },
                            new Epic {
                                Title = "Build Engine",
                                PercentComplete = 60
                            },
                            new Epic {
                                Title = "App. Registry",
                                PercentComplete = 0
                            }
                        }
                    },
                    new KeyResult {
                        Title = "Sentry",
                        Epics = new[] {
                            new Epic {
                                Title = "Studio App",
                                PercentComplete = 0
                            },
                            new Epic {
                                Title = "Ingress",
                                PercentComplete = 40
                            }
                        }
                    },
                    new KeyResult {
                        Title = "Blah",
                        Epics = new[] {
                            new Epic {
                                Title = "Do Stuff",
                                PercentComplete = 0
                            },
                            new Epic {
                                Title = "More Shit",
                                PercentComplete = 40
                            },
                            new Epic {
                                Title = "Catman",
                                PercentComplete = 40
                            }
                        }
                    }
                }
            },
            new Objective {
                Title = "Improve developer experience",
                KeyResults = new [] {
                    new KeyResult {
                        Title = "Visual Studio",
                        Epics = new[] {
                            new Epic {
                                Title = "Plugins",
                                PercentComplete = 50
                            },
                            new Epic {
                                Title = "Explorer",
                                PercentComplete = 20
                            }
                        }
                    },
                    new KeyResult {
                        Title = "Boilerplates",
                        Epics = new[] {
                            new Epic {
                                Title = "Interaction Layers",
                                PercentComplete = 30
                            },
                            new Epic {
                                Title = "Multi service",
                                PercentComplete = 0
                            }
                        }
                    }
                }
            },
            new Objective {
                Title = "Empowering developers to build",
                KeyResults = new [] {
                    new KeyResult {
                        Title = "Documentation",
                        Epics = new[] {
                            new Epic {
                                Title = "Mindset",
                                PercentComplete = 20
                            },
                            new Epic {
                                Title = "Frameworks",
                                PercentComplete = 10
                            },
                            new Epic {
                                Title = "Tooling",
                                PercentComplete = 0
                            },
                            new Epic {
                                Title = "Lookg & feel",
                                PercentComplete = 20
                            }
                        }
                    },
                    new KeyResult {
                        Title = "Quickstarts",
                        Epics = new[] {
                            new Epic {
                                Title = "Backend",
                                PercentComplete = 0
                            },
                            new Epic {
                                Title = "Aurelia",
                                PercentComplete = 0
                            },
                            new Epic {
                                Title = "Angular",
                                PercentComplete = 0
                            }
                        }
                    }
                }
            }


        }.AsQueryable();
    }
}