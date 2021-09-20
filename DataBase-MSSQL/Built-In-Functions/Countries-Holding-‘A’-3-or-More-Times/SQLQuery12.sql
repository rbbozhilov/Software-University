SELECT  CountryName,IsoCode
      FROM Countries
	  WHERE CountryName LIKE ('%[Aa]%[Aa]%[Aa]%')
	  ORDER BY IsoCode ASC