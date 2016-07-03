# CafePressApi
## Overview
CafePress API methods in C#/.NET.  Based on ZendeskApi_v2 by mozts2005 and adapted to handle CafePress' XML.
(The original library is here at https://github.com/mozts2005/ZendeskApi_v2)

Licensed under the Apache 2.0 license, as the original ZendeskApi_v2 library was.  
See http://www.apache.org/licenses/LICENSE-2.0.html for more information.

## What is this for?

In the creation of a front-end site for my CafePress store (the store itself is at http://www.cafepress.com/dracotal), 
I wanted to pull real-time product information off of CafePress and not have to duplicate the data or manually edit 
it at all times.  CafePress conveniently provides an API and allows developers to access it with their API key.  
To learn more about the API, visit the Cafepress Developer's Network at http://www.cafepress.com/cp/developers/docs/

A demo will be uploaded at some point in order to further clarify what I'm doing.  Or you can view a DurandalJS-based 
website that makes use of the CafePressAPI at http://dracotal.com (DISCLAIMER: It is my front-end site 
for my CafePress store), which makes extensive use of the CafePressAPI library there.

## A little more info
The original ZendeskApi_v2 library was geared around JSON data that was retrieved by the ZenDesk API.  CafePress 
includes no such option, everything is generated as XML.  So I had to make sure that the XML could be parsed and the 
product data sorted into objects as it should be.  This involved a little pain and gnashing of teeth to figure out, 
but I eventually got it done :)
