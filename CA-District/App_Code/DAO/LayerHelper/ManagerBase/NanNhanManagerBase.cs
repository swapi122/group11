




/*
'===============================================================================
'  LayerHelper.CAQ.BL.NanNhanManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class NanNhanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NanNhanManagerBase()
		{
			// Nothing for now.
		}
		
		public NanNhanEntity Insert(NanNhanEntity _NanNhanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NanNhanEntity, true);
			}
			return _NanNhanEntity;
		}

		
		public NanNhanEntity Insert(Guid Id, string HoTen, string HoTenThuongDung, string BiDanh, string MaRutGon, Guid IdGioiTinh, DateTime SinhNgay, string QueQuan, string DiaChiNoiO, Guid IdQuocTich, string Cmnd, Guid IdDanToc, Guid IdTrinhDoHocVan, Guid IdNgheNghiep, Guid IdTinhTrangChinhTri, Guid IdTinhTrangTheTrang, string ThongTinKhac, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			NanNhanEntity _NanNhanEntity = new NanNhanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NanNhanEntity.Id = Id;
				_NanNhanEntity.HoTen = HoTen;
				_NanNhanEntity.HoTenThuongDung = HoTenThuongDung;
				_NanNhanEntity.BiDanh = BiDanh;
				_NanNhanEntity.MaRutGon = MaRutGon;
				_NanNhanEntity.IdGioiTinh = IdGioiTinh;
				_NanNhanEntity.SinhNgay = SinhNgay;
				_NanNhanEntity.QueQuan = QueQuan;
				_NanNhanEntity.DiaChiNoiO = DiaChiNoiO;
				_NanNhanEntity.IdQuocTich = IdQuocTich;
				_NanNhanEntity.Cmnd = Cmnd;
				_NanNhanEntity.IdDanToc = IdDanToc;
				_NanNhanEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
				_NanNhanEntity.IdNgheNghiep = IdNgheNghiep;
				_NanNhanEntity.IdTinhTrangChinhTri = IdTinhTrangChinhTri;
				_NanNhanEntity.IdTinhTrangTheTrang = IdTinhTrangTheTrang;
				_NanNhanEntity.ThongTinKhac = ThongTinKhac;
				_NanNhanEntity.IdNguoiTao = IdNguoiTao;
				_NanNhanEntity.NgayTao = NgayTao;
				_NanNhanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NanNhanEntity.NgayCapNhat = NgayCapNhat;
				_NanNhanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NanNhanEntity, true);
			}
			return _NanNhanEntity;
		}

		public NanNhanEntity Insert(string HoTen, string HoTenThuongDung, string BiDanh, string MaRutGon, Guid IdGioiTinh, DateTime SinhNgay, string QueQuan, string DiaChiNoiO, Guid IdQuocTich, string Cmnd, Guid IdDanToc, Guid IdTrinhDoHocVan, Guid IdNgheNghiep, Guid IdTinhTrangChinhTri, Guid IdTinhTrangTheTrang, string ThongTinKhac, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			NanNhanEntity _NanNhanEntity = new NanNhanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NanNhanEntity.HoTen = HoTen;
				_NanNhanEntity.HoTenThuongDung = HoTenThuongDung;
				_NanNhanEntity.BiDanh = BiDanh;
				_NanNhanEntity.MaRutGon = MaRutGon;
				_NanNhanEntity.IdGioiTinh = IdGioiTinh;
				_NanNhanEntity.SinhNgay = SinhNgay;
				_NanNhanEntity.QueQuan = QueQuan;
				_NanNhanEntity.DiaChiNoiO = DiaChiNoiO;
				_NanNhanEntity.IdQuocTich = IdQuocTich;
				_NanNhanEntity.Cmnd = Cmnd;
				_NanNhanEntity.IdDanToc = IdDanToc;
				_NanNhanEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
				_NanNhanEntity.IdNgheNghiep = IdNgheNghiep;
				_NanNhanEntity.IdTinhTrangChinhTri = IdTinhTrangChinhTri;
				_NanNhanEntity.IdTinhTrangTheTrang = IdTinhTrangTheTrang;
				_NanNhanEntity.ThongTinKhac = ThongTinKhac;
				_NanNhanEntity.IdNguoiTao = IdNguoiTao;
				_NanNhanEntity.NgayTao = NgayTao;
				_NanNhanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NanNhanEntity.NgayCapNhat = NgayCapNhat;
				_NanNhanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NanNhanEntity, true);
			}
			return _NanNhanEntity;
		}

		public bool Update(NanNhanEntity _NanNhanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NanNhanFields.Id == _NanNhanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NanNhanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NanNhanEntity _NanNhanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NanNhanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string HoTen, string HoTenThuongDung, string BiDanh, string MaRutGon, Guid IdGioiTinh, DateTime SinhNgay, string QueQuan, string DiaChiNoiO, Guid IdQuocTich, string Cmnd, Guid IdDanToc, Guid IdTrinhDoHocVan, Guid IdNgheNghiep, Guid IdTinhTrangChinhTri, Guid IdTinhTrangTheTrang, string ThongTinKhac, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NanNhanEntity _NanNhanEntity = new NanNhanEntity(Id);
				if (adapter.FetchEntity(_NanNhanEntity))
				{
				
					_NanNhanEntity.HoTen = HoTen;
					_NanNhanEntity.HoTenThuongDung = HoTenThuongDung;
					_NanNhanEntity.BiDanh = BiDanh;
					_NanNhanEntity.MaRutGon = MaRutGon;
					_NanNhanEntity.IdGioiTinh = IdGioiTinh;
					_NanNhanEntity.SinhNgay = SinhNgay;
					_NanNhanEntity.QueQuan = QueQuan;
					_NanNhanEntity.DiaChiNoiO = DiaChiNoiO;
					_NanNhanEntity.IdQuocTich = IdQuocTich;
					_NanNhanEntity.Cmnd = Cmnd;
					_NanNhanEntity.IdDanToc = IdDanToc;
					_NanNhanEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
					_NanNhanEntity.IdNgheNghiep = IdNgheNghiep;
					_NanNhanEntity.IdTinhTrangChinhTri = IdTinhTrangChinhTri;
					_NanNhanEntity.IdTinhTrangTheTrang = IdTinhTrangTheTrang;
					_NanNhanEntity.ThongTinKhac = ThongTinKhac;
					_NanNhanEntity.IdNguoiTao = IdNguoiTao;
					_NanNhanEntity.NgayTao = NgayTao;
					_NanNhanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_NanNhanEntity.NgayCapNhat = NgayCapNhat;
					_NanNhanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_NanNhanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NanNhanEntity _NanNhanEntity = new NanNhanEntity(Id);
				if (adapter.FetchEntity(_NanNhanEntity))
				{
					adapter.DeleteEntity(_NanNhanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NanNhanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTen(string HoTen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTenThuongDung(string HoTenThuongDung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBiDanh(string BiDanh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdGioiTinh(Guid IdGioiTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySinhNgay(DateTime SinhNgay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByQueQuan(string QueQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDiaChiNoiO(string DiaChiNoiO)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdQuocTich(Guid IdQuocTich)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCmnd(string Cmnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDanToc(Guid IdDanToc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNgheNghiep(Guid IdNgheNghiep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinhTrangChinhTri(Guid IdTinhTrangChinhTri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinhTrangTheTrang(Guid IdTinhTrangTheTrang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThongTinKhac(string ThongTinKhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanEntity", filter);
			}
			return toReturn;
		}
		

		
		public NanNhanEntity SelectOne(Guid Id)
		{
			NanNhanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NanNhanEntity _NanNhanEntity = new NanNhanEntity(Id);
				if (adapter.FetchEntity(_NanNhanEntity))
				{
					toReturn = _NanNhanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectAllLST()
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, null, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByHoTenLST(string HoTen)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByHoTenLST_Paged(string HoTen, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenRDT(string HoTen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenRDT_Paged(string HoTen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByHoTenThuongDungLST(string HoTenThuongDung)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByHoTenThuongDungLST_Paged(string HoTenThuongDung, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenThuongDungRDT(string HoTenThuongDung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenThuongDungRDT_Paged(string HoTenThuongDung, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByBiDanhLST(string BiDanh)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByBiDanhLST_Paged(string BiDanh, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBiDanhRDT(string BiDanh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBiDanhRDT_Paged(string BiDanh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdGioiTinhLST(Guid IdGioiTinh)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdGioiTinhLST_Paged(Guid IdGioiTinh, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdGioiTinhRDT(Guid IdGioiTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdGioiTinhRDT_Paged(Guid IdGioiTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectBySinhNgayLST(DateTime SinhNgay)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectBySinhNgayLST_Paged(DateTime SinhNgay, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySinhNgayRDT(DateTime SinhNgay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySinhNgayRDT_Paged(DateTime SinhNgay, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByQueQuanLST(string QueQuan)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByQueQuanLST_Paged(string QueQuan, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByQueQuanRDT(string QueQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByQueQuanRDT_Paged(string QueQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByDiaChiNoiOLST(string DiaChiNoiO)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByDiaChiNoiOLST_Paged(string DiaChiNoiO, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDiaChiNoiORDT(string DiaChiNoiO)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDiaChiNoiORDT_Paged(string DiaChiNoiO, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdQuocTichLST(Guid IdQuocTich)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdQuocTichLST_Paged(Guid IdQuocTich, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuocTichRDT(Guid IdQuocTich)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuocTichRDT_Paged(Guid IdQuocTich, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByCmndLST(string Cmnd)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByCmndLST_Paged(string Cmnd, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCmndRDT(string Cmnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCmndRDT_Paged(string Cmnd, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdDanTocLST(Guid IdDanToc)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdDanTocLST_Paged(Guid IdDanToc, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanTocRDT(Guid IdDanToc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanTocRDT_Paged(Guid IdDanToc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdTrinhDoHocVanLST(Guid IdTrinhDoHocVan)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdTrinhDoHocVanLST_Paged(Guid IdTrinhDoHocVan, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTrinhDoHocVanRDT(Guid IdTrinhDoHocVan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTrinhDoHocVanRDT_Paged(Guid IdTrinhDoHocVan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdNgheNghiepLST(Guid IdNgheNghiep)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdNgheNghiepLST_Paged(Guid IdNgheNghiep, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNgheNghiepRDT(Guid IdNgheNghiep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNgheNghiepRDT_Paged(Guid IdNgheNghiep, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdTinhTrangChinhTriLST(Guid IdTinhTrangChinhTri)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdTinhTrangChinhTriLST_Paged(Guid IdTinhTrangChinhTri, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangChinhTriRDT(Guid IdTinhTrangChinhTri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangChinhTriRDT_Paged(Guid IdTinhTrangChinhTri, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdTinhTrangTheTrangLST(Guid IdTinhTrangTheTrang)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdTinhTrangTheTrangLST_Paged(Guid IdTinhTrangTheTrang, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangTheTrangRDT(Guid IdTinhTrangTheTrang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangTheTrangRDT_Paged(Guid IdTinhTrangTheTrang, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByThongTinKhacLST(string ThongTinKhac)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByThongTinKhacLST_Paged(string ThongTinKhac, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThongTinKhacRDT(string ThongTinKhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThongTinKhacRDT_Paged(string ThongTinKhac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null);
			}
			return _NanNhanCollection;
		}
		
		// Return EntityCollection<NanNhanEntity>
		public EntityCollection<NanNhanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanEntity> _NanNhanCollection = new EntityCollection<NanNhanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanCollection = new EntityCollection(new NanNhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
